using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Listener
{
    internal sealed class EventSet
    {
        private readonly Dictionary<Type, Delegate> m_events = new Dictionary<Type, Delegate>();
        public void Add(Type eventKey, Delegate handler)
        {
            lock (m_events)
            {
                Delegate d;
                m_events.TryGetValue(eventKey, out d);
                m_events[eventKey] = Delegate.Combine(d, handler);
            }
        }
        public void Remove(Type eventKey, Delegate handler)
        {
            lock (m_events)
            {
                Delegate d;
                if (m_events.TryGetValue(eventKey, out d))
                {
                    d = Delegate.Remove(d, handler);
                    if (d != null) m_events[eventKey] = d;
                    else m_events.Remove(eventKey);
                }
            }
        }

        public void Raise(Type eventKey, Object sender, EventArgs e)
        {
            Delegate d;
            lock (m_events)
            {
                m_events.TryGetValue(eventKey, out d);
            }
            if (d != null)
            {
                d.DynamicInvoke(new object[] { sender, e });
            }
        }
    }
}