using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterData data = new MonsterData();
            MonsterEntity entity = new MonsterEntity(data);

            data.Refresh();

            entity.Save();

            var SaveListener = Model.Listener.ListenerManage.GetListener(Model.Listener.ListenerOptions.Save);
            var RefreshListener = Model.Listener.ListenerManage.GetListener(Model.Listener.ListenerOptions.Refresh);

            SaveListener.AddListener(typeof(MonsterData), OnSave);
            SaveListener.AddListener(typeof(MonsterEntity), OnSave);

            RefreshListener.AddListener(typeof(MonsterData), OnRefresh);
            RefreshListener.AddListener(typeof(MonsterEntity), OnRefresh);

            data.Refresh();

            entity.Save();

            Console.Read();
        }
        static void OnSave(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetType());
        }
        static void OnRefresh(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetType());

        }
    }
}
