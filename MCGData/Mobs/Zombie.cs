using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Zombie : Mob
    {
        public bool IsVillager { get; set; }
        public bool IsBaby { get; set; }

        public Zombie()
        {
            id = "Zombie";
        }
    }
}
