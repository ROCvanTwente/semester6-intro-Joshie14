using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
    public interface IVehicle
    {
        int Snelheid { get; set; }
        int AantalWielen { get; }
        string Kleur { get; set; }

        void Verhogen(int hoeveelheid);

        void Verlagen(int hoeveelheid);

        string SnelheidWeergeven();
    }
}