using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public class Car : IVehicle
    {
        public int Snelheid { get; set; }
        public int AantalWielen { get; } = 4;
        public string Kleur { get; set; }

        public Car(string Kleur)
        {
            Kleur = Kleur;
            Snelheid = 0;
        }

        public string SnelheidWeergeven()
        {
            return $"De huidige snelheid van de auto is {Snelheid} km/u.";
        }

        public void Verhogen(int hoeveelheid)
        {
            Snelheid += hoeveelheid;
        }

        public void Verlagen(int hoeveelheid)
        {
            Snelheid -= hoeveelheid;
        }
    }
}