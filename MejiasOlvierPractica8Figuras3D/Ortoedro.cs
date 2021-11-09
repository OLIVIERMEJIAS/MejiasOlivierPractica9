using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Ortoedro : Figura
    {
        /// <summary>
        /// Propiedad del atributo double largo
        /// </summary>
        public double Largo { get; set; }
        /// <summary>
        /// Propiedad del atributo double ancho
        /// </summary>
        public double Ancho { get; set; }
        /// <summary>
        /// Propiedad del atributo double altura
        /// </summary>
        public double Altura { get; set; }

        /// <summary>
        /// Genera un objeto tipo Ortoedro
        /// </summary>
        /// <remarks>Necesita los argumentos; double largo
        /// double ancho, double altura y string tipo de figura
        /// </remarks>
        /// <param name="larg"></param>
        /// <param name="anch"></param>
        /// <param name="alt"></param>
        /// <param name="tipo"></param>
        public Ortoedro(double larg, double anch, double alt,string tipo) : base(tipo)
        {
            Largo = larg;
            Ancho = anch;
            Altura = alt;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override double calcularArea()
        {
            return 2*((Largo * Ancho)+(Largo * Altura)+(Ancho * Altura));
        }
        /// <summary>
        /// método sobre escrito para calcular el volumen
        /// </summary>
        public override double calcularVolumen()
        {
            return Largo * Ancho * Altura;
        }
      

    }
}
