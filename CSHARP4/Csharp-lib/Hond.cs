using System;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public class Hond : Dier
    {
        public Hond(int gewicht, string name) : base(gewicht, name)
        {
        }

        public override string MakeSound()
        {
            return "woef.mp3"; // Bestandsnaam voor het geluid
        }
    }
}