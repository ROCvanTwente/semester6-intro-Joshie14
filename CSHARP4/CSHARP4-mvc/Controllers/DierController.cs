using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AnimalWorld;

namespace MyAnimalsMVC.Controllers
{
    public class DierController : Controller
    {
        // gemaakt dooor: arda
        private static List<Dier> dieren = new List<Dier>
        {
            new Hond(15, "Rex"),
            new Hond(12, "Buddy"),
            new Kip(2, "Henny"),
            new Kip(3, "Karel"),
            new Varken(80, "Babe"),
            new Varken(100, "Pumba"),
            new Eend(80, "Donald"),
            new Eend(100, "Duck"),
            new Koe(5, "Moomie"),
            new Koe(4, "Milkers"),
            new Slang(5, "Nagini"),
            new Slang(4, "Kaa"),
            new Vos(5, "Foxy"),
            new Vos(4, "Red"),
            new Schaap(50, "Shaun"),
            new Schaap(55, "Dolly")
        };

        public IActionResult Index()
        {
            return View(dieren);
        }

        [HttpGet]
        public IActionResult SpeelGeluid(int id)
        {
            var dier = dieren.FirstOrDefault(d => d.Id == id);
            if (dier == null)
                return NotFound();

            return Json(new { bestand = dier.MakeSound() });
        }

        [HttpPost]
        public IActionResult Verplaats(int id, string direction, int step)
        {
            var dier = dieren.FirstOrDefault(d => d.Id == id);
            if (dier == null)
                return NotFound();

            if (Enum.TryParse(direction, out Direction parsedDirection))
            {
                dier.Move(parsedDirection, step);
            }

            return Json(new { x = dier.Position.X, y = dier.Position.Y });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VoegToe(string name, string type, int gewicht)
        {
            Dier nieuwDier = type switch
            {
                "Hond" => new Hond(gewicht, name),
                "Kip" => new Kip(gewicht, name),
                "Eend" => new Eend(gewicht, name),
                "Varken" => new Varken(gewicht, name),
                "Koe" => new Koe(gewicht, name),
                "Slang" => new Slang(gewicht, name),
                "Vos" => new Vos(gewicht, name),
                "Schaap" => new Schaap(gewicht, name),
                _ => null
            };

            if (nieuwDier != null)
            {
                dieren.Add(nieuwDier);
            }

            return RedirectToAction("Index");
        }
    }
}