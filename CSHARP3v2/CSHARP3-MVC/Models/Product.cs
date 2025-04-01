using System.ComponentModel.DataAnnotations;

namespace CSHARP3.Models
{
    public abstract class Product
    {
        // gemaakt dooor: joshua
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public decimal Prijs { get; set; }

        [Required]
        public int Voorraad { get; set; }

        public string ProductType { get; protected set; }

        protected Product()
        { }

        protected Product(string titel, decimal prijs, int voorraad)
        {
            Titel = titel;
            Prijs = prijs;
            Voorraad = voorraad;
        }

        internal decimal BerekenTotaleWaarde()
        {
            throw new NotImplementedException();
        }

        internal bool VerkoopProduct(int aantal)
        {
            throw new NotImplementedException();
        }
    }
}