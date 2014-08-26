using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class ZombiePigman : Zombie
    {
        public short Anger { get; set; }

        public ZombiePigman()
        {
            id = "PigZombie";
        }
    }
}
