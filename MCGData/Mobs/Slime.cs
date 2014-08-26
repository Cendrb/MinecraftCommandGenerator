using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Slime : Mob
    {
        public int? Size { get; set; }

        public Slime()
        {
            id = "Slime";
        }
    }
}
