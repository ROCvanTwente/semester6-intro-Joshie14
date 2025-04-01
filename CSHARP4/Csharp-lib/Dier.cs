using System;
using System.Drawing;

namespace AnimalWorld
{
    // gemaakt dooor: arda
    public abstract class Dier : IAnimal
    {
        private static int nextId = 1;
        public int Id { get; }
        public int Gewicht { get; set; }
        public Point Position { get; set; }
        public string Name { get; set; }

        private Random rnd = new Random();

        public Dier(int gewicht, string name)
        {
            Id = nextId++;
            Gewicht = gewicht;
            Name = name;
            Position = new Point(rnd.Next(0, 1000), rnd.Next(0, 1000));
        }

        public abstract string MakeSound();

        public void Move(Direction direction, int step)
        {
            int x = Position.X;
            int y = Position.Y;

            switch (direction)
            {
                case Direction.Up:
                    y += step;
                    break;

                case Direction.Down:
                    y -= step;
                    break;

                case Direction.Left:
                    x -= step;
                    break;

                case Direction.Right:
                    x += step;
                    break;
            }

            // Nieuwe positie instellen
            Position = new Point(x, y);
            Console.WriteLine($"{Name} verplaatst naar X:{Position.X}, Y:{Position.Y}");
        }
    }
}