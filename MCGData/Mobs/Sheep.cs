using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData.Mobs
{
    public class Sheep : Mob
    {
        public bool Sheared { get; set; }
        public byte? Color { get; set; }

        public Sheep()
        {
            id = "Sheep";
        }
    }
}
