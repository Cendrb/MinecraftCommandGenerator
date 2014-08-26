using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Skeleton : Mob
    {
        public byte SkeletonType { get; set; }

        public Skeleton()
        {
            id = "Skeleton";
        }
    }
}
