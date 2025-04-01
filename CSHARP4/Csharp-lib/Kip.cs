using System;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public class Kip : Dier
    {
        public Kip(int gewicht, string name) : base(gewicht, name)
        {
        }

        public override string MakeSound()
        {
            return "tok.mp3"; // Bestandsnaam voor het geluid
        }
    }
}