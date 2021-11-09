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
      
        string tipo;
        string datosEnCadena;
        /// <summary>
        /// Devuelve el tipo, método Getter
        /// </summary>
        /// <returns>string tipo</returns>
        public string getTipo()
        {
            return tipo;
        }
        /// <summary>
        /// Getter para el atributo string datosEnCadena
        /// </summary>
        /// <returns></returns>
        public string getDatosEnCadena()
        {
            return datosEnCadena;
        }
        /// <summary>
        /// Setter para el atributo string datosEnCadena 
        /// que guarda los datos esenciales en una cadena
        /// </summary>
        /// <param name="cadena"></param>
        public void setDatosEnCadena(string cadena)
        {
            datosEnCadena = cadena;
        }

        /// <summary>
        /// cosntruye una instancia Figura
        /// </summary>
        /// <param name="tip"></param>
        public Figura(string tip)
        {
            
            tipo = tip;
        }
        /// <summary>
        /// método abstracto
        /// </summary>
        public abstract double calcularArea();

        /// <summary>
        /// método abstracto
        /// </summary>
        public abstract double calcularVolumen();
        /// <summary>
        /// método virtual
        /// </summary>
        /// <returns></returns>
        public virtual string mensajeCalculos(double area,double volumen)
        {
            return $"El área de su figura es: {Math.Round(area,2)} cm2 y el volumen es : {Math.Round(volumen,2)} cm3";
        }

        
    }
}
