using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class DataBase
    {
        public virtual void Refresh()
        {
            Listener.ListenerManage.GetListener(Listener.ListenerOptions.Refresh).Raise(this.GetType(), this, new EventArgs());
        }
    }
}
