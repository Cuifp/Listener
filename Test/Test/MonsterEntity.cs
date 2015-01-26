using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MonsterEntity : Model.Entity.EntityBase
    {
        public MonsterData Data { get; set; }
        public MonsterEntity(MonsterData data)
        {
            this.Data = data;
        }
    }
}
