using System;

namespace CSHARP3.Models
{
    // gemaakt dooor: joshua
    public class DVD : Product
    {
        // Parameterloze constructor voor EF
        public DVD()
        { }

        // Constructor met parameters
        public DVD(string titel, decimal prijs, int voorraad)
            : base(titel, prijs, voorraad)
        {
            ProductType = "DVD";
        }
    }
}