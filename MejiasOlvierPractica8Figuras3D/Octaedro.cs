using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Octaedro : Figura
    {
        //atributo
        double arista;

        /// <summary>
        /// Construye una instancia tipo Octaedro
        /// </summary>
        /// <remarks>Necesita los argumentos: double arista y string tipo de figura
        /// </remarks>
        /// <param name="arist"></param>
        /// <param name="tipo"></param>
        public Octaedro(double arist,string tipo) : base(tipo)
        {
            arista = arist;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override void calcularArea()
        {
            areaAsignar(2 * Math.Sqrt(3) * Math.Pow(arista, 2));
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override void calcularVolumen()
        {
            volumenAsignar((Math.Sqrt(2) * Math.Pow(arista, 2)) / 3);
        }

        /// <summary>
        /// Getter de la arista
        /// </summary>
        /// <returns>double arista</returns>
        public double aristaConsultar()
        {
            return arista;
        }

    }
}
