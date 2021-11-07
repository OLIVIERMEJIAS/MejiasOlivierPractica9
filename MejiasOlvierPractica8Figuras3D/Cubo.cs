using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Cubo : Figura
    {
        double lado;

        public Cubo(double lad,string tipo) : base(tipo)
        {
            lado = lad;
           
        }

        public override void calcularArea()
        {
            areaAsignar(6* Math.Pow(lado, 2));
        }

        public override void calcularVolumen()
        {
            volumenAsignar(Math.Pow(lado, 3));
        }
        public double ladoConsultar()
        {
            return lado;
        }
    }
}
