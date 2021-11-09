using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Prisma : Figura
    {
        /// <summary>
        /// Propiedad del atributo double ladoBase
        /// </summary>
        public double LadoBase { get; set; }
        /// <summary>
        /// Propiedad del atributo double apotema
        /// </summary>
        public double Apotema { get; set; }
        /// <summary>
        /// Propiedad del atributo double Altura
        /// </summary>
        public double Altura { get; set; }
        

        /// <summary>
        /// Construye un objeto Prisma
        /// </summary>
        /// /// <remarks>Necesita los argumentos: double lado,
        /// double apotema, double altura y string tipo
        /// </remarks>
        /// <param name="lad"></param>
        /// <param name="apot"></param>
        /// <param name="alt"></param>
        /// <param name="tipo"></param>
        public Prisma(double lad, double apot, double alt,string tipo) : base(tipo)
        {
            LadoBase = lad;
            Apotema = apot;
            Altura = alt;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override double calcularArea()
        {
            double periBase = 5 * LadoBase;
            return periBase * (Altura + Apotema);
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override double calcularVolumen()
        {
            double areaBase = (5 * LadoBase * Apotema) / 2;
            return areaBase * Altura;
        }

        
    }
}
