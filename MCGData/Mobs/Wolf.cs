using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Wolf : Mob
    {
        public bool Angry { get; set; }
        public byte CollarColor { get; set; }

        public Wolf()
        {
            CollarColor = 14;
            id = "Wolf";
        }
    }
}
