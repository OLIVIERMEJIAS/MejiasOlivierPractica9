using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Tetraedro : Figura
    {
        double arista;


        public Tetraedro(double arist, string tipo) : base(tipo)
        {
            arista = arist;

        }

        public override void calcularArea()
        {
            areaAsignar(Math.Sqrt(3) * Math.Pow(arista, 2));
        }

        public override void calcularVolumen()
        {
            volumenAsignar((Math.Sqrt(2) * Math.Pow(arista, 3)) / 12);
        }

        public double aristaConsultar()
        {
            return arista;
        }
    }
}
