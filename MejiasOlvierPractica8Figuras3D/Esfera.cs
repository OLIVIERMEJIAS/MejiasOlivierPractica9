using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Esfera : Figura
    {
        double radio;
        /// <summary>
        /// Propiedad del atributo double radio
        /// </summary>
        public double Radio
        {
            get => this.radio;
            set => this.radio = value;
        }
        /// <summary>
        /// Constructor de una instancia tipo Esfera
        /// </summary>
        /// <remarks>Requiere double radio y string tipo como argumentos</remarks>
        /// <param name="rad"></param>
        /// <param name="tipo"></param>
        public Esfera(double rad, string tipo) : base(tipo)
        {
            Radio = rad;
        }
        /// <summary>
        /// método sobreescrito del área
        /// </summary>
        public override double calcularArea()
        {
            return 4 * System.Math.PI * Math.Pow(Radio, 2);
        }
        /// <summary>
        /// método sobreescrito del volumen
        /// </summary>
        public override double calcularVolumen()
        {
            return (4 * System.Math.PI * Math.Pow(Radio, 3)) / 3;
        }

        
        

    }
}
