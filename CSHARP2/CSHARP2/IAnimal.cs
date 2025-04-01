using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public interface IAnimal
    {
        string Name { get; set; }
        double Weight { get; set; }
        int Age { get; set; }

        void UpdateName(string newName);
        void UpdateWeight(double newWeight);
        void UpdateAge(int newAge);
        string GetDetails();
    }
}
