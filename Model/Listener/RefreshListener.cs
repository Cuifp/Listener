using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Listener
{
    internal class RefreshListener : Listener
    {
        public static RefreshListener Instance;
        private RefreshListener() { }
        static RefreshListener()
        {
            Instance = new RefreshListener();
        }
    }
}
