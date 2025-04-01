using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Csharp_lib;

namespace CSHARP3.Controllers
{
    // gemaakt dooor: arda
    public class DierController : Controller
    {
        public IActionResult Index()
        {
            // Maak instanties van onze dieren
            List<Dier> dieren = new List<Dier>
            {
                new Hond(15),
                new Kip(2),
                new Varken(80)
            };

            return View(dieren);
        }

        [HttpGet]
        public IActionResult SpeelGeluid(string type, int gewicht)
        {
            var geluiden = new Dictionary<string, string>
                {
                    { "Hond", "woef.mp3" },
                    { "Kip", "tok.mp3" },
                    { "Varken", "knor.mp3" }
                };

            if (geluiden.ContainsKey(type))
            {
                return Json(new { bestand = geluiden[type] });
            }

            return NotFound();
        }
    }
}