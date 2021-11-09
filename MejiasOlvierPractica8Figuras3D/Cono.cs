using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    class Cono : Figura
    {
        //atributos
        double radio;
        double generatriz;
        double altura;

        /// <summary>
        /// construye un nuevo objeto Cono
        /// </summary>
        /// <remarks>Requiere double radio,
        /// double generatriz, double altura y string tipo como argumentos</remarks>
        /// <param name="rad"></param>
        /// <param name="gen"></param>
        /// <param name="alt"></param>
        /// <param name="tipo"></param>
        public Cono(double rad,double gen,double alt,string tipo) : base(tipo)
        {
            radio = rad;
            generatriz = gen;
            altura = alt;
        }

        /// <summary>
        /// sobreescribe el método de calcular el área
        /// </summary>
        public override double calcularArea()
        {
            return (Math.PI * radio) *(radio * generatriz);
        }

        /// <summary>
        /// sobreescribe el método de calcular el volumen
        /// </summary>
        public override double calcularVolumen()
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        /// <summary>
        /// Getter del radio
        /// </summary>
        /// <returns>double radio</returns>
        public double getRadio()
        {
            return radio;
        }

        /// <summary>
        /// Getter de la altura
        /// </summary>
        /// <returns>double altura</returns>
        public double getAltura()
        {
            return altura;
        }

        /// <summary>
        /// Getter de la generatriz
        /// </summary>
        /// <returns>double generatriz</returns>
        public double getGeneratriz()
        {
            return generatriz;
        }
    }
}
