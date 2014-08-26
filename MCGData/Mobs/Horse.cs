using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Horse : Mob
    {
        public bool ChestedHorse { get; set; }
        public bool Tame { get; set; }
        public int Type { get; set; }
        public Item ArmorItem { get; set; }
        public Item SaddleItem { get; set; }
        public bool Saddle { get; set; }

        public Horse()
        {
            id = "EntityHorse";
        }
    }
}
