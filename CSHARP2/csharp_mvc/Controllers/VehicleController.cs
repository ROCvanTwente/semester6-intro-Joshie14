using CSHARP2;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace csharp_mvc.Controllers
{
    public class VehicleController : Controller
    {
        private static List<IVehicle> vehicles = new List<IVehicle>
        {
            new Car("Rood"),
            new Bicycle("Blauw")
        };

        public IActionResult Index()
        {
            return View(vehicles);
        }

        public IActionResult Accelerate(int id)
        {
            if (id < 0 || id >= vehicles.Count)
                return NotFound();

            vehicles[id].Verhogen(10);
            return RedirectToAction("Index");
        }

        public IActionResult Decelerate(int id)
        {
            if (id < 0 || id >= vehicles.Count)
                return NotFound();

            vehicles[id].Verlagen(10);
            return RedirectToAction("Index");
        }

        public IActionResult ShowSpeed(int id)
        {
            if (id < 0 || id >= vehicles.Count)
                return NotFound();

            ViewBag.Message = vehicles[id].SnelheidWeergeven();
            return View("Index", vehicles);
        }
    }
}