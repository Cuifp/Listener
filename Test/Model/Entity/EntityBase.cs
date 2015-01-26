using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public abstract class EntityBase
    {
        public virtual void Save()
        {
            Listener.ListenerManage.GetListener(Listener.ListenerOptions.Save).Raise(this.GetType(), this, new EventArgs());
        }
    }
}
