using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Guardian : Mob
    {
        public bool Elder { get; set; }

        public Guardian()
        {
            id = "Guardian";
        }
    }
}
