using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCGData;
using MCGData.Mobs;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            serialize();
            Console.ReadKey();
        }

        private static void deserialize()
        {
            string text = Clipboard.GetText();
            StringReader stringReader = new StringReader(text);
            JsonReader reader = new JsonTextReader(stringReader);

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new FloatConverter());
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.DefaultValueHandling = DefaultValueHandling.Ignore;
            serializer.Formatting = Formatting.None;
            Mob result = serializer.Deserialize<Mob>(reader);
        }

        private static void serialize()
        {
            Zombie zombie = new Zombie();
            zombie.CustomName = "Penis";
            Item weapon = new Item();
            weapon.Count = 23;
            weapon.id = "minecraft:carrot";

            Item.Tag weaponTag = new Item.Tag();
            Enchantment enchantment = new Enchantment();
            enchantment.Enchant = Enchantments.Knockback;
            enchantment.lvl = 69;
            weaponTag.ench.Add(enchantment);
            weaponTag.display.Name = "Large Penis of Raping";
            weaponTag.display.Lore.Add("Fap.");
            weaponTag.display.Lore.Add("Fap.");
            weaponTag.display.Lore.Add("Fap.");

            weapon.tag = weaponTag;

            zombie.Equipment[0] = weapon;
            zombie.DropChances[0] = 1;

            Entity sheep = new Cow();
            sheep.id = "Sheep";
            sheep.CustomName = "Kurva";
            zombie.Riding = sheep;

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new FloatConverter());
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.DefaultValueHandling = DefaultValueHandling.Ignore;
            serializer.Formatting = Formatting.None;
            StringWriter stringWriter = new StringWriter();
            JsonTextWriter writer = new JsonTextWriter(stringWriter);
            writer.QuoteName = false;
            serializer.Serialize(writer, zombie);
            writer.Close();
            string json = stringWriter.ToString();
            string summonCommand = "/summon Zombie ~ ~1 ~ ";
            string result = summonCommand + json;

            Clipboard.SetText(result);
            Console.WriteLine(result);
        }
    }
}
