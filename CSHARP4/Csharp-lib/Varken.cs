using System;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public class Varken : Dier
    {
        public Varken(int gewicht, string name) : base(gewicht, name)
        {
        }

        public override string MakeSound()
        {
            return "knor.mp3"; // Bestandsnaam voor het geluid
        }
    }
}