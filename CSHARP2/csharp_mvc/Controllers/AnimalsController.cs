using CSHARP2;
using Microsoft.AspNetCore.Mvc;

namespace csharp_mvc.Controllers
{
    public class AnimalsController : Controller
    {
        private static List<IAnimal> animals = new List<IAnimal>
        {
            new Dog("Max", 10.5, 3),
            new Cat("Luna", 4.3, 2)
        };

        public ActionResult Index()
        {
            return View(animals);
        }

        public ActionResult Edit(string name)
        {
            var animal = animals.Find(a => a.Name == name);
            if (animal == null)
                return HttpNotFound();

            return View(animal);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Edit(string name, string newName, double weight, int age)
        {
            var animal = animals.Find(a => a.Name == name);
            if (animal != null)
            {
                animal.UpdateName(newName);
                animal.UpdateWeight(weight);
                animal.UpdateAge(age);
            }
            return RedirectToAction("Index");
        }
    }
}
