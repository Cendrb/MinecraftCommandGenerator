using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Enderman : Mob
    {
        public short carried { get; set; }
        public short carriedData { get; set; }
        public int EndermiteCount { get; set; }

        public Enderman()
        {
            id = "Enderman";
        }
    }
}
