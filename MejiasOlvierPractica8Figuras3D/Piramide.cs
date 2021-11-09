using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Piramide : Figura
    {
        /// <summary>
        /// Propiedad del atributo double apotemaBase
        /// </summary>
        public double ApotemaBase { get; set; }
        /// <summary>
        /// Propiedad del atributo double apotemaLado
        /// </summary>
        public double ApotemaLado { get; set; }
        /// <summary>
        /// Propiedad del atributo double altura
        /// </summary>
        public double Altura { get; set; }
        /// <summary>
        /// Propiedad del atributo double ladoBase
        /// </summary>
        public double LadoBase { get; set; }

        /// <summary>
        /// Construye una instancia de tipo Piramide
        /// </summary>
        /// <remarks>Necesita los argumentos: double apotema de la base,
        /// double apotema de un lado o cara,
        /// double altura y string tipo de figura
        /// </remarks>
        /// <param name="apoB"></param>
        /// <param name="apoL"></param>
        /// <param name="alt"></param>
        /// <param name="ladoB"></param>
        /// <param name="tipo"></param>
        public Piramide(double apoB, double apoL, double alt, 
            double ladoB,string tipo) : base(tipo)
        {
            ApotemaBase = apoB;
            ApotemaLado = apoL;
            Altura = alt;
            LadoBase = ladoB;
        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override double calcularArea()
        {
            double periBase = 4 * LadoBase;
            return (periBase * (ApotemaBase + ApotemaLado)) / 2 ;
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override double calcularVolumen()
        {
            double areaBase = Math.Pow(LadoBase,2);
            return (areaBase * Altura) / 3;
        }

        
    }
}
