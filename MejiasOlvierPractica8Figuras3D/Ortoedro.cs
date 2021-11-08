using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Ortoedro : Figura
    {
        //atributos
        double largo;
        double ancho;
        double altura;

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
            largo = larg;
            ancho = anch;
            altura = alt;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override void calcularArea()
        {
            areaAsignar(2*((largo * ancho)+(largo * altura)+(ancho * altura)));
        }
        /// <summary>
        /// método sobre escrito para calcular el volumen
        /// </summary>
        public override void calcularVolumen()
        {
            volumenAsignar(largo * ancho * altura);
        }
        /// <summary>
        /// Getter del largo
        /// </summary>
        /// <returns>double largo</returns>
        public double largoConsultar()
        {
            return largo;
        }

        /// <summary>
        /// Getter del ancho
        /// </summary>
        /// <returns>double ancho</returns>
        public double anchoConsultar()
        {
            return ancho;
        }

        /// <summary>
        /// Getter de la altura
        /// </summary>
        /// <returns>double altura</returns>
        public double alturaConsultar()
        {
            return altura;
        }

    }
}
