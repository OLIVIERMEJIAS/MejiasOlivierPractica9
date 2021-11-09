using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Octaedro : Figura
    {
        double arista;
        /// <summary>
        /// Propiedad del atributo double arista
        /// </summary>
        public double Arista
        {
            get => this.arista;
            set => this.arista = value;
        }

        /// <summary>
        /// Construye una instancia tipo Octaedro
        /// </summary>
        /// <remarks>Necesita los argumentos: double arista y string tipo de figura
        /// </remarks>
        /// <param name="arist"></param>
        /// <param name="tipo"></param>
        public Octaedro(double arist,string tipo) : base(tipo)
        {
            Arista = arist;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override double calcularArea()
        {
            return 2 * Math.Sqrt(3) * Math.Pow(Arista, 2);
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override double calcularVolumen()
        {
            return (Math.Sqrt(2) * Math.Pow(Arista, 2)) / 3;
        }

        

    }
}
