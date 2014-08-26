using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    public class Entity
    { 
        public string id { get; set; }
        public string CustomName { get; set; }
        public bool CustomNameVisible { get; set; }
        public bool Silent { get; set; }
        public double[] Motion { get; set; }
        public double[] Rotation { get; set; }
        public short Fire { get; set; }
        public short Air { get; set; }
        public bool Invulnerable { get; set; }
        public int PortalCooldown { get; set; }
        public Entity Riding { get; set; }

        public Entity()
        {
            Motion = new double[3];
            Rotation = new double[2];
        }
    }
}
