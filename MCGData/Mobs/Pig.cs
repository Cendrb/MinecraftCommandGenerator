using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Pig : Mob
    {
        public bool Saddle { get; set; }

        public Pig()
        {
            id = "Pig";
        }
    }
}
