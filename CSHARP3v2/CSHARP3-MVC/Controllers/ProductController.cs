using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CSHARP3.Models;
using CSHARP3.ViewModels;
using CSHARP3_MVC.Data;
using CSHARP3.Data;


//<!-- gemaakt door: Jim-->


namespace CSHARP3.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Overzicht van alle producten en de totale waarde van de voorraad
        public IActionResult Overzicht()
        {
            var producten = _context.Products.ToList();
            var totaleWaarde = producten.Sum(p => p.BerekenTotaleWaarde());

            var viewModel = new RapportViewModel
            {
                Products = producten,
                TotaleVoorraadWaarde = totaleWaarde
            };

            return View(viewModel);
        }

        // Weergave van de verkooppagina
        public IActionResult Verkoop(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            var verkoopViewModel = new VerkoopViewModel
            {
                ProductId = product.Id
            };

            return View(verkoopViewModel);
        }

        // Actie om een product te verkopen en de voorraad bij te werken
        [HttpPost]
        public IActionResult Verkoop(VerkoopViewModel model)
        {
            var product = _context.Products.Find(model.ProductId);
            if (product == null)
            {
                return NotFound();
            }

            if (product.VerkoopProduct(model.Aantal))
            {
                _context.SaveChanges();
                return RedirectToAction("Overzicht");
            }
            else
            {
                ModelState.AddModelError("", "Niet genoeg voorraad beschikbaar!");
            }

            return View(model);
        }
    }
}
