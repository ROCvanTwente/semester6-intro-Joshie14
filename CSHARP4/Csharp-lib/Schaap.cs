using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public class Schaap : Dier
    {
        public Schaap(int gewicht, string name) : base(gewicht, name)
        {
        }

        public override string MakeSound()
        {
            return "meh.mp3"; // Bestandsnaam voor het geluid
        }
    }
}