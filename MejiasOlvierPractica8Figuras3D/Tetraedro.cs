using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Tetraedro : Figura
    {
        /// <summary>
        /// Propiedad del atributo double arista
        /// </summary>
        public double Arista { get; set; }
        

        /// <summary>
        /// Construye un objeto tipo Tetraedro
        /// </summary>
        /// <remarks>Necesita los argumentos: double arista y de string tipo
        /// </remarks>
        /// <param name="arist"></param>
        /// <param name="tipo"></param>
        public Tetraedro(double arist, string tipo) : base(tipo)
        {
            Arista = arist;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override double calcularArea()
        {
            return Math.Sqrt(3) * Math.Pow(Arista, 2);
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override double calcularVolumen()
        {
            return (Math.Sqrt(2) * Math.Pow(Arista, 3)) / 12;
        }

        
    }
}
