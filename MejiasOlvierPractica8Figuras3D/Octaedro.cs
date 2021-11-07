using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Octaedro : Figura
    {
        double arista;

        public Octaedro(double arist) : base()
        {
            arista = arist;

        }

        public override void calcularArea()
        {
            areaAsignar(2 * Math.Sqrt(3) * Math.Pow(arista, 2));
        }

        public override void calcularVolumen()
        {
            volumenAsignar((Math.Sqrt(2) * Math.Pow(arista, 2)) / 3);
        }

    }
}
