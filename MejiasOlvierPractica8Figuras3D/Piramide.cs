using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Piramide : Figura
    {
        double apotemaBase;
        double apotemaLado;
        double altura;
        double ladoBase;

        public Piramide(double apoB, double apoL, double alt, 
            double ladoB,string tipo) : base(tipo)
        {
            apotemaBase = apoB;
            apotemaLado = apoL;
            altura = alt;
            ladoBase = ladoB;
        }

        public override void calcularArea()
        {
            double periBase = 4 * ladoBase;
            areaAsignar((periBase * (apotemaBase + apotemaLado)) / 2 );
        }

        public override void calcularVolumen()
        {
            double areaBase = Math.Pow(ladoBase,2);
            volumenAsignar((areaBase * altura) / 3);
        }

        public double apotemaBaseConsultar()
        {
            return apotemaBase;
        }
        public double apotemaLadoConsultar()
        {
            return apotemaLado;
        }
        public double alturaConsultar()
        {
            return altura;
        }
        public double ladoBaseConsultar()
        {
            return ladoBase;
        }
    }
}
