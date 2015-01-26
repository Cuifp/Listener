using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Listener
{
    internal class SaveListener : Listener
    {
        public static SaveListener Instance;
        private SaveListener() { }
        static SaveListener()
        {
            Instance = new SaveListener();
        }
    }
}
