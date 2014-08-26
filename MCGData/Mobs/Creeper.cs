using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Creeper : Mob
    {
        public bool powered { get; set; }
        public byte ExplosionRadius { get; set; }
        public short Fuse { get; set; }
        public bool ignited { get; set; }

        public Creeper()
        {
            ExplosionRadius = 3;
            Fuse = 30;
            id = "Creeper";
        }
    }
}
