using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    public enum Enchantments { None, Protection, FireProtection, FeatherFalling, BlastProtection, ProjectileProtection, Respiration, AquaAffinity, Thorns, DepthStrider, Unbreaking, Sharpness, Smite, BaneofArthropods, Knockback, FireAspect, Looting, Efficiency, SilkTouch, Fortune, Power, Punch, Flame, Infinity, LuckOfTheSea, Lure }
    public static class EnchantmentConverter
    {
        static Dictionary<Enchantments, short> gameIds;

        static EnchantmentConverter()
        {
            gameIds = new Dictionary<Enchantments, short>();

            gameIds.Add(Enchantments.Protection, 0);
            gameIds.Add(Enchantments.FireProtection, 1);
            gameIds.Add(Enchantments.FeatherFalling, 2);
            gameIds.Add(Enchantments.BlastProtection, 3);
            gameIds.Add(Enchantments.ProjectileProtection, 4);
            gameIds.Add(Enchantments.Respiration, 5);
            gameIds.Add(Enchantments.AquaAffinity, 6);
            gameIds.Add(Enchantments.Thorns, 7);
            gameIds.Add(Enchantments.DepthStrider, 8);

            gameIds.Add(Enchantments.Sharpness, 16);
            gameIds.Add(Enchantments.Smite, 17);
            gameIds.Add(Enchantments.BaneofArthropods, 18);
            gameIds.Add(Enchantments.Knockback, 19);
            gameIds.Add(Enchantments.FireAspect, 20);
            gameIds.Add(Enchantments.Looting, 21);

            gameIds.Add(Enchantments.Efficiency, 32);
            gameIds.Add(Enchantments.SilkTouch, 33);
            gameIds.Add(Enchantments.Unbreaking, 34);
            gameIds.Add(Enchantments.Fortune, 35);

            gameIds.Add(Enchantments.Power, 48);
            gameIds.Add(Enchantments.Punch, 49);
            gameIds.Add(Enchantments.Flame, 50);
            gameIds.Add(Enchantments.Infinity, 51);

            gameIds.Add(Enchantments.LuckOfTheSea, 61);
            gameIds.Add(Enchantments.Lure, 62);
        }

        public static short GetId(this Enchantments enchant)
        {
            return gameIds[enchant];
        }

        public static Enchantments GetEnchantment(this short id)
        {
            foreach(KeyValuePair<Enchantments, short> pair in gameIds)
                if(pair.Value == id)
                    return pair.Key;
            return Enchantments.None;
        }
    }
}
