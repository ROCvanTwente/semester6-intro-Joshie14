using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public class Slang : Dier
    {
        public Slang(int gewicht, string name) : base(gewicht, name)
        {
        }

        public override string MakeSound()
        {
            return "his.mp3"; // Bestandsnaam voor het geluid
        }
    }
}