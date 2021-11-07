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

        public Cono(double rad,double gen,double alt,string tipo) : base(tipo)
        {
            radio = rad;
            generatriz = gen;
            altura = alt;
        }

        public override void calcularArea()
        {
            areaAsignar((System.Math.PI * radio) *(radio * generatriz));
        }

        public override void calcularVolumen()
        {
            volumenAsignar((System.Math.PI * Math.Pow(radio, 2) * altura) / 3);
        }

        public double radioConsultar()
        {
            return radio;
        }

        public double alturaConsultar()
        {
            return altura;
        }

        public double generatrizConsultar()
        {
            return generatriz;
        }
    }
}
