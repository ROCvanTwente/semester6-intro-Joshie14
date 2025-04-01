
//<!-- gemaakt door: Jim-->

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CSHARP3.Models;

namespace CSHARP3.ViewModels
{
    // Basis view model voor producten
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titel is verplicht")]
        [StringLength(100, ErrorMessage = "Titel mag maximaal 100 karakters zijn")]
        [Display(Name = "Titel")]
        public string Titel { get; set; }

        [Required(ErrorMessage = "Prijs is verplicht")]
        [Range(0.01, 1000, ErrorMessage = "Prijs moet tussen €0,01 en €1000 liggen")]
        [Display(Name = "Prijs (€)")]
        public decimal Prijs { get; set; }

        [Required(ErrorMessage = "Voorraad is verplicht")]
        [Range(0, 1000, ErrorMessage = "Voorraad moet tussen 0 en 1000 liggen")]
        [Display(Name = "Voorraad")]
        public int Voorraad { get; set; }
    }

    // View model voor CDs
    public class CDViewModel : ProductViewModel
    {
        [Required(ErrorMessage = "Aantal liedjes is verplicht")]
        [Range(1, 100, ErrorMessage = "Aantal liedjes moet tussen 1 en 100 liggen")]
        [Display(Name = "Aantal liedjes")]
        public int AantalLiedjes { get; set; }
    }

    // View model voor DVDs
    public class DVDViewModel : ProductViewModel
    {
        // DVD-specifieke eigenschappen kunnen hier worden toegevoegd
    }

    // View model voor het verkopen van producten
    public class VerkoopViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Aantal is verplicht")]
        [Range(1, 1000, ErrorMessage = "Aantal moet tussen 1 en 1000 liggen")]
        [Display(Name = "Aantal te verkopen")]
        public int Aantal { get; set; }
    }

    // View model voor de rapportage pagina
    public class RapportViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public decimal TotaleVoorraadWaarde { get; set; }
    }
}