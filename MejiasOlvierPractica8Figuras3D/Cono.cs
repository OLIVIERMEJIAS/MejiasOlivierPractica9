using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Cono : Figura
    {

        double radio;
        double generatriz;
        double altura;

        public Cono(double rad,double gen) : base()
        {
            radio = rad;
            generatriz = gen;
        }

        public override void calcularArea()
        {
            areaAsignar((System.Math.PI * radio) *(radio * generatriz));
        }

        public override void calcularVolumen()
        {
            volumenAsignar((System.Math.PI * Math.Pow(radio, 2) * altura) / 3);
        }
    }
}
