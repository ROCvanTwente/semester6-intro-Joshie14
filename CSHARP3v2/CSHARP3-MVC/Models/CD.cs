using System;

namespace CSHARP3.Models
{
    // gemaakt dooor: joshua
    public class CD : Product
    {
        public int AantalLiedjes { get; set; }

        // Parameterloze constructor voor EF
        public CD()
        { }

        // Constructor met parameters
        public CD(string titel, decimal prijs, int voorraad, int aantalLiedjes)
            : base(titel, prijs, voorraad)
        {
            AantalLiedjes = aantalLiedjes;
            ProductType = "CD";
        }
    }
}