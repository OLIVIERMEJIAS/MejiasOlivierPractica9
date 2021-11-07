using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Prisma : Figura
    {
        double ladoBase;
        double apotema;
        double altura;

        public Prisma(double lad, double apot, double alt,string tipo) : base(tipo)
        {
            ladoBase = lad;
            apotema = apot;
            altura = alt;

        }

        public override void calcularArea()
        {
            double periBase = 5 * ladoBase;
            areaAsignar(periBase * (altura + apotema));
        }

        public override void calcularVolumen()
        {
            double areaBase = (5 * ladoBase * apotema) / 2;
            volumenAsignar(areaBase * altura);
        }

        public double apotemaConsultar()
        {
            return apotema;
        }

        public double ladoBaseConsultar()
        {
            return ladoBase;
        }

        public double alturaConsultar()
        {
            return altura;
        }
    }
}
