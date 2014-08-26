using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Rabbit : Mob
    {
        public int? RabbitType { get; set; }

        public Rabbit()
        {
            id = "Rabbit";
        }
    }
}
