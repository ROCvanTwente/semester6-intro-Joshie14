using System;

namespace Csharp_lib
{
    // gemaakt dooor: joshua
    // Subklasse Hond
    public class Hond : Dier
    {
        public Hond(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "woef.mp3"; // Bestandsnaam voor het geluid
        }
    }
}