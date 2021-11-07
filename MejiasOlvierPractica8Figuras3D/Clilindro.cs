using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Cilindro : Figura
    {
        double radio;
        double altura;

        public Cilindro(double rad,double alt,string tipo) : base(tipo)
        {
            radio = rad;
            altura = alt;
        }

        public override void calcularArea()
        {
            areaAsignar((2*Math.PI) * (radio * (altura + radio)));
        }

        public override void calcularVolumen()
        {
            volumenAsignar(Math.PI * Math.Pow(radio,2) * altura);
        }

        public double radioConsultar()
        {
            return radio;
        }

        public double alturaConsultar()
        {
            return altura;
        }
    }
}
