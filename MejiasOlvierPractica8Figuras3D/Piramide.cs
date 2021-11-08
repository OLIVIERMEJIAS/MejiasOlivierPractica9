using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Piramide : Figura
    {
        //atributos
        double apotemaBase;
        double apotemaLado;
        double altura;
        double ladoBase;


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
            apotemaBase = apoB;
            apotemaLado = apoL;
            altura = alt;
            ladoBase = ladoB;
        }

        /// <summary>
        /// método sobreescrito para calcular el área
        /// </summary>
        public override void calcularArea()
        {
            double periBase = 4 * ladoBase;
            areaAsignar((periBase * (apotemaBase + apotemaLado)) / 2 );
        }

        /// <summary>
        /// método sobreescrito para calcular el volumen
        /// </summary>
        public override void calcularVolumen()
        {
            double areaBase = Math.Pow(ladoBase,2);
            volumenAsignar((areaBase * altura) / 3);
        }

        /// <summary>
        /// Getter para la apotema de la base
        /// </summary>
        /// <returns>double apotemaBase</returns>
        public double apotemaBaseConsultar()
        {
            return apotemaBase;
        }

        /// <summary>
        /// Getter del lado de la apotema
        /// </summary>
        /// <returns>double apotemaLado</returns>
        public double apotemaLadoConsultar()
        {
            return apotemaLado;
        }

        /// <summary>
        /// Getter de la altura
        /// </summary>
        /// <returns>double altura</returns>
        public double alturaConsultar()
        {
            return altura;
        }

        /// <summary>
        /// Getter del lado de la base
        /// </summary>
        /// <returns>double ladoBase</returns>
        public double ladoBaseConsultar()
        {
            return ladoBase;
        }
    }
}
