using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Listener
{
    public abstract class Listener
    {
        private EventSet _EventSet = new EventSet();
        public void AddListener(Type key, EventHandler<EventArgs> handler)
        {
            _EventSet.Add(key, handler);
        }
        public void RemoveListener(Type key, EventHandler<EventArgs> handler)
        {
            _EventSet.Remove(key, handler);
        }
        internal void Raise(Type eventKey, Object sender, EventArgs e)
        {
            _EventSet.Raise(eventKey, sender, e);
        }
    }
}
