using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public interface IAnimal
    {
        // Property voor de huidige positie op het speelveld
        Point Position { get; set; }

        // Property voor de naam van het dier
        string Name { get; set; }

        // Methode die het geluid van het dier afspeelt
        string MakeSound();

        // Methode om het dier te verplaatsen
        void Move(Direction direction, int step);
    }
}