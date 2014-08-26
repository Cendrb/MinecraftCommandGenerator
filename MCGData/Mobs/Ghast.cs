using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Ghast : Mob
    {
        public int ExplosionPower { get; set; }

        public Ghast()
        {
            ExplosionPower = 1;
            id = "Ghast";
        }
    }
}
