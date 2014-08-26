using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class IronGolem : Mob
    {
        public bool PlayerCreated { get; set; }

        public IronGolem()
        {
            id = "VillagerGolem";
        }
    }
}
