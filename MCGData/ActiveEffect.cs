using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGData
{
    public class ActiveEffect
    {
        public byte Id { get; set; }
        public byte Amplifier { get; set; }
        public int Duration { get; set; }
        public bool Ambient { get; set; }
        public bool ShowParticles { get; set; }
    }
}
