using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Prisma : Figura
    {
        //atributos
        double ladoBase;
        double apotema;
        double altura;

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
            ladoBase = lad;
            apotema = apot;
            altura = alt;

        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override void calcularArea()
        {
            double periBase = 5 * ladoBase;
            areaAsignar(periBase * (altura + apotema));
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override void calcularVolumen()
        {
            double areaBase = (5 * ladoBase * apotema) / 2;
            volumenAsignar(areaBase * altura);
        }

        /// <summary>
        /// Getter para la apotema
        /// </summary>
        /// <returns>double apotema</returns>
        public double apotemaConsultar()
        {
            return apotema;
        }

        /// <summary>
        /// Getter para el lado de la base
        /// </summary>
        /// <returns>double ladoBase</returns>
        public double ladoBaseConsultar()
        {
            return ladoBase;
        }

        /// <summary>
        /// Getter para la altura
        /// </summary>
        /// <returns>double altura</returns>
        public double alturaConsultar()
        {
            return altura;
        }
    }
}
