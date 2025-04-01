using System;

namespace Csharp_lib
{
    // gemaakt dooor: joshua
    // Subklasse Kip
    public class Kip : Dier
    {
        public Kip(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "tok.mp3"; // Bestandsnaam voor het geluid
        }
    }
}