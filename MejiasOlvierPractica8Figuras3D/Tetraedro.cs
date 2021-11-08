using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Tetraedro : Figura
    {
        //atributos
        double arista;

        /// <summary>
        /// Construye un objeto tipo Tetraedro
        /// </summary>
        /// <remarks>Necesita los argumentos: double arista y de string tipo
        /// </remarks>
        /// <param name="arist"></param>
        /// <param name="tipo"></param>
        public Tetraedro(double arist, string tipo) : base(tipo)
        {
            arista = arist;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override void calcularArea()
        {
            areaAsignar(Math.Sqrt(3) * Math.Pow(arista, 2));
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override void calcularVolumen()
        {
            volumenAsignar((Math.Sqrt(2) * Math.Pow(arista, 3)) / 12);
        }

        /// <summary>
        /// Getter del atributo arista
        /// </summary>
        /// <returns>dobule arista</returns>
        public double aristaConsultar()
        {
            return arista;
        }
    }
}
