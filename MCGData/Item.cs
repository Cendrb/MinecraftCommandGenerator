using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    public class Item
    {
        public string id { get; set; }
        public byte Count { get; set; }
        public byte Slot { get; set; }
        public short Damage { get; set; }
        public Tag tag { get; set; }

        public class Tag
        {
            public bool Unbreakable { get; set; }
            List<string> CanDestroy { get; set; }

            public int RepairCost { get; set; }
            public List<Enchantment> ench { get; set; }
            public List<Enchantment> StoredEnchantments { get; set; }

            public DisplayTag display { get; set; }
            public int HideFlags { get; set; }

            public Tag()
            {
                ench = new List<Enchantment>();
                StoredEnchantments = new List<Enchantment>();
                display = new DisplayTag();
            }
        }

        public class DisplayTag
        {
            public string Name { get; set; }
            public List<string> Lore { get; set; }

            public DisplayTag()
            {
                Lore = new List<string>();
            }
        }
    }
}
