using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Prisma : Figura
    {
        double lado;
        double apotema;
        double altura;

        public Prisma(double lad, double apot, double alt) : base()
        {
            lado = lad;
            apotema = apot;
            altura = alt;

        }

        public override void calcularArea()
        {
            double periBase = 5 * lado;
            areaAsignar(periBase * (altura + apotema));
        }

        public override void calcularVolumen()
        {
            double areaBase = (5 * lado * apotema) / 2;
            volumenAsignar(areaBase * altura);
        }
    }
}
