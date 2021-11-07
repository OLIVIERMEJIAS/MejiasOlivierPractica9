using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Ortoedro : Figura
    {
        double largo;
        double ancho;
        double altura;

        public Ortoedro(double larg, double anch, double alt) : base()
        {
            largo = larg;
            ancho = anch;
            altura = alt;

        }

        public override void calcularArea()
        {
            areaAsignar(2*((largo * ancho)+(largo * altura)+(ancho * altura)));
        }

        public override void calcularVolumen()
        {
            volumenAsignar(largo * ancho * altura);
        }
    }
}
