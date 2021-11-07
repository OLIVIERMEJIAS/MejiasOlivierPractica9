using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Esfera : Figura
    {
        double radio;

        public Esfera(double rad) : base()
        {
            radio = rad;
        }

        public override void calcularArea()
        {
            areaAsignar(4 * System.Math.PI * Math.Pow(radio, 2));
        }

        public override void calcularVolumen()
        {
            volumenAsignar((4 * System.Math.PI * Math.Pow(radio, 3)) / 3);
        }

        
    }
}
