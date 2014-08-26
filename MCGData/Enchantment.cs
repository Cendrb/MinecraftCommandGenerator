using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    [JsonObject(MemberSerialization.OptOut)]
    public class Enchantment
    {
        [JsonIgnore]
        public Enchantments Enchant
        {
            get;
            set;
        }

        public short id
        {
            get
            {
                return Enchant.GetId();
            }
            set
            {
                Enchant = value.GetEnchantment();
            }
        }
        public short lvl { get; set; }
    }
}
