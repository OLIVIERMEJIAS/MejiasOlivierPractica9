using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Cubo : Figura
    {
        //atributo
        double lado;

        /// <summary>
        /// construye una instancia Cubo
        /// </summary>
        /// <remarks>Requiere double lado y string tipo como argumentos</remarks>
        /// <param name="lad"></param>
        /// <param name="tipo"></param>
        public Cubo(double lad,string tipo) : base(tipo)
        {
            lado = lad;
           
        }
        /// <summary>
        /// método sobreescrito del cálculo del área
        /// </summary>
        public override double calcularArea()
        {
            return 6 * Math.Pow(lado, 2);
        }
        /// <summary>
        /// método sobreescrito del cálculo del volumen
        /// </summary>
        public override double calcularVolumen()
        {
            return Math.Pow(lado, 3);
        }
        /// <summary>
        /// Getter de la medida del lado
        /// </summary>
        /// <returns>double lado</returns>
        public double getLado()
        {
            return lado;
        }
    }
}
