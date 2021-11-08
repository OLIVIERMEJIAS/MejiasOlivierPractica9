using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Esfera : Figura
    {
        //atributo
        double radio;

        /// <summary>
        /// Constructor de una instancia tipo Esfera
        /// </summary>
        /// <remarks>Requiere double radio y string tipo como argumentos</remarks>
        /// <param name="rad"></param>
        /// <param name="tipo"></param>
        public Esfera(double rad, string tipo) : base(tipo)
        {
            radio = rad;
        }
        /// <summary>
        /// método sobreescrito del área
        /// </summary>
        public override void calcularArea()
        {
            areaAsignar(4 * System.Math.PI * Math.Pow(radio, 2));
        }
        /// <summary>
        /// método sobreescrito del volumen
        /// </summary>
        public override void calcularVolumen()
        {
            volumenAsignar((4 * System.Math.PI * Math.Pow(radio, 3)) / 3);
        }

        /// <summary>
        /// Getter del radio
        /// </summary>
        /// <returns>double radio</returns>
        public double radioConsultar()
        {
            return radio;
        }

    }
}
