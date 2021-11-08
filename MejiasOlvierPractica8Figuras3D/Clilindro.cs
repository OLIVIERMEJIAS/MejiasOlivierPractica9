using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Cilindro : Figura
    {
        //atributos
        double radio;
        double altura;
        /// <summary>
        /// Construye una instancia tipo Cilindro
        /// </summary>
        /// <remarks>Requiere double radio,
        /// double altura y string tipo como argumentos</remarks>
        /// <param name="rad"></param>
        /// <param name="alt"></param>
        /// <param name="tipo"></param>
        public Cilindro(double rad,double alt,string tipo) : base(tipo)
        {
            radio = rad;
            altura = alt;
        }

        /// <summary>
        /// método de sobreescrituta para calcular el área
        /// </summary>
        public override void calcularArea()
        {
            areaAsignar((2*Math.PI) * (radio * (altura + radio)));
        }
        /// <summary>
        /// método de sobreescrituta para calcular el volumen
        /// </summary>
        public override void calcularVolumen()
        {
            volumenAsignar(Math.PI * Math.Pow(radio,2) * altura);
        }
        /// <summary>
        /// Getter del radio
        /// </summary>
        /// <returns>double radio</returns>
        public double radioConsultar()
        {
            return radio;
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
