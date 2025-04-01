using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public class Koe : Dier
    {
        public Koe(int gewicht, string name) : base(gewicht, name)
        {
        }

        public override string MakeSound()
        {
            return "moe.mp3"; // Bestandsnaam voor het geluid
        }
    }
}