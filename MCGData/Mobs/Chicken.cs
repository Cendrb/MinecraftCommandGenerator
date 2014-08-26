using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Chicken : Mob
    {
        public bool IsChickenJockey { get; set; }
        public int? EggLayTime { get; set; }

        public Chicken()
        {
            id = "Chicken";
        }
    }
}
