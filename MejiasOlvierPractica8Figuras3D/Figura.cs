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


        public Figura()
        {
            area = 0;
            volumen = 0;
        }

        public abstract void calcularArea();

        public abstract void calcularVolumen();

        public virtual string mensajeCalculos()
        {
            return $"El área de su figura es: {area} y el volumen es: {volumen}";
        }

        public double areaConsultar()
        {
            return area;
        }

        public double volumenConsultar()
        {
            return volumen;
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
