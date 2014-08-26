using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    public class Mob : Entity
    {
        public float AbsorptionAmount { get; set; }
        public List<ActiveEffect> ActiveEffects { get; set; }
        public Item[] Equipment { get; set; }
        public float[] DropChances { get; set; }
        public bool CanPickUpLoot { get; set; }
        public bool NoAI { get; set; }
        public bool PersistenceRequired { get; set; }

        public Mob()
        {
            Equipment = new Item[5];
            DropChances = new float[5];
        }
    }
}
