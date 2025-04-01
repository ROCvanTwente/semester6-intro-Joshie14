using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        // Constructor in de klasse, niet in de interface!
        public Cat(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public void UpdateName(string newName) => Name = newName;
        public void UpdateWeight(double newWeight) => Weight = newWeight;
        public void UpdateAge(int newAge) => Age = newAge;

        public string GetDetails()
        {
            return $"Cat: {Name}, Weight: {Weight} kg, Age: {Age} years";
        }
    }
}
