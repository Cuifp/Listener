using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Listener
{
    public class ListenerManage
    {
        public static Listener GetListener(ListenerOptions option)
        {
            Listener listener = null;
            switch (option)
            {
                case ListenerOptions.Save:
                    listener = SaveListener.Instance;
                    break;
                case ListenerOptions.Refresh:
                    listener = RefreshListener.Instance;
                    break;
                default:
                    break;
            }
            return listener;
        }
    }
}
