using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    abstract class Figura
    {
        double area;
        double volumen;
        string tipo;


        public Figura(string tip)
        {
            area = 0;
            volumen = 0;
            tipo = tip;
        }

        public abstract void calcularArea();

        public abstract void calcularVolumen();

        public virtual string mensajeCalculos()
        {
            return $"El área de su figura es: {Math.Round(area,2)} cm2 y el volumen es : {Math.Round(volumen,2)} cm3";
        }

        public double areaConsultar()
        {
            return area;
        }

        public double volumenConsultar()
        {
            return volumen;
        }

        public string tipoConsultar()
        {
            return tipo;
        }



        public void areaAsignar(double ar)
        {
             area = ar;
        }

        public void volumenAsignar(double vol)
        {
            volumen = vol;
        }
    }
}
