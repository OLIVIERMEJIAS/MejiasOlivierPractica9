using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    abstract class Figura
    {
        //atributos
        double area;
        double volumen;
        string tipo;

        /// <summary>
        /// cosntruye una instancia Figura
        /// </summary>
        /// <param name="tip"></param>
        public Figura(string tip)
        {
            area = 0;
            volumen = 0;
            tipo = tip;
        }
        /// <summary>
        /// método abstracto
        /// </summary>
        public abstract void calcularArea();

        /// <summary>
        /// método abstracto
        /// </summary>
        public abstract void calcularVolumen();
        /// <summary>
        /// método virtual
        /// </summary>
        /// <returns></returns>
        public virtual string mensajeCalculos()
        {
            return $"El área de su figura es: {Math.Round(area,2)} cm2 y el volumen es : {Math.Round(volumen,2)} cm3";
        }

        /// <summary>
        /// Getter del área
        /// </summary>
        /// <returns>double area</returns>
        public double areaConsultar()
        {
            return area;
        }

        /// <summary>
        /// Getter del volumen
        /// </summary>
        /// <returns>double volumen</returns>
        public double volumenConsultar()
        {
            return volumen;
        }

        /// <summary>
        /// Getter del tipo de figura
        /// </summary>
        /// <returns>string tipo</returns>
        public string tipoConsultar()
        {
            return tipo;
        }

        /// <summary>
        /// Setter del área
        /// </summary>
        /// <remarks>Requiere un double area como argumento</remarks>
        /// <param name="ar"></param>
        public void areaAsignar(double ar)
        {
             area = ar;
        }
        /// <summary>
        /// Setter del volumen
        /// </summary>
        /// <remarks>Requiere un double volumen como argumento</remarks>
        /// <param name="vol"></param>
        public void volumenAsignar(double vol)
        {
            volumen = vol;
        }
    }
}
