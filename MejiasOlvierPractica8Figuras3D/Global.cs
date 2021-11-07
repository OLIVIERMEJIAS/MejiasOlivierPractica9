using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejiasOlvierPractica8Figuras3D
{
    internal class Global
    {
        private static ArrayList historialCilindros;
        private static ArrayList historialConos;
        private static ArrayList historialCubos;
        private static ArrayList historialEsferas;
        private static ArrayList historialPiramides;
        private static ArrayList historialPrismas;
        private static ArrayList historialOctaedros;
        private static ArrayList historialOrtoedros;
        private static ArrayList historialTetraedros;

        public Global()
        {
            if (historialCilindros == null)
            {
                historialCilindros = new ArrayList();
                historialConos = new ArrayList();
                historialCubos = new ArrayList();
                historialEsferas = new ArrayList();
                historialPiramides = new ArrayList();
                historialPrismas = new ArrayList();
                historialOctaedros = new ArrayList();
                historialOrtoedros = new ArrayList();
                historialTetraedros = new ArrayList();
            }
        }

        public ArrayList historialCiliConsultar()
        {
            return historialCilindros;
        }

        public void historialCiliAgregar(Object obj)
        {
            historialCilindros.Add(obj);
        }

        public ArrayList historialCuboConsultar()
        {
            return historialCubos;
        }

        public void historialCuboAgregar(Object obj)
        {
            historialCubos.Add(obj);
        }

        public ArrayList historialConoConsultar()
        {
            return historialConos;
        }

        public void historialConoAgregar(Object obj)
        {
            historialConos.Add(obj);
        }

        public ArrayList historialEsfeConsultar()
        {
            return historialEsferas;
        }

        public void historialEsfeAgregar(Object obj)
        {
            historialEsferas.Add(obj);
        }

        public ArrayList historialPiraConsultar()
        {
            return historialPiramides;
        }

        public void historialPiraAgregar(Object obj)
        {
            historialPiramides.Add(obj);
        }

        public ArrayList historialPrisConsultar()
        {
            return historialPrismas;
        }

        public void historialPrisAgregar(Object obj)
        {
            historialPrismas.Add(obj);
        }

        public ArrayList historialOctaConsultar()
        {
            return historialOctaedros;
        }

        public void historialOctaAgregar(Object obj)
        {
            historialOctaedros.Add(obj);
        }

        public ArrayList historialOrtoeConsultar()
        {
            return historialOrtoedros;
        }

        public void historialOrtoeAgregar(Object obj)
        {
            historialOrtoedros.Add(obj);
        }

        public ArrayList historialTetraConsultar()
        {
            return historialTetraedros;
        }

        public void historialTetraAgregar(Object obj)
        {
            historialTetraedros.Add(obj);
        }

       
    }

    
}
