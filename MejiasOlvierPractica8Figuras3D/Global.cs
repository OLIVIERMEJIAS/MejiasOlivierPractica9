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
        //ArrayLists con ámbito global en la memoria
        private static ArrayList historialCilindros;
        private static ArrayList historialConos;
        private static ArrayList historialCubos;
        private static ArrayList historialEsferas;
        private static ArrayList historialPiramides;
        private static ArrayList historialPrismas;
        private static ArrayList historialOctaedros;
        private static ArrayList historialOrtoedros;
        private static ArrayList historialTetraedros;

        //Construye un objeto tipo Global, si están en null, los crea
        //todos, como se crean todos o ninguno solo se pregunta el estado de uno
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

        /// <summary>
        /// Retorna el historial de objetos Cilindro
        /// </summary>
        /// <returns></returns>
        public ArrayList historialCiliConsultar()
        {
            return historialCilindros;
        }

        /// <summary>
        /// Agrega un nuevo objeto Cilindro al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialCiliAgregar(Object obj)
        {
            historialCilindros.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Cubo
        /// </summary>
        /// <returns></returns>
        public ArrayList historialCuboConsultar()
        {
            return historialCubos;
        }

        /// <summary>
        /// Agrega un nuevo objeto Cubo al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialCuboAgregar(Object obj)
        {
            historialCubos.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Cono
        /// </summary>
        /// <returns></returns>
        public ArrayList historialConoConsultar()
        {
            return historialConos;
        }

        /// <summary>
        /// Agrega un nuevo objeto Cono al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialConoAgregar(Object obj)
        {
            historialConos.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Esfera
        /// </summary>
        /// <returns></returns>
        public ArrayList historialEsfeConsultar()
        {
            return historialEsferas;
        }

        /// <summary>
        /// Agrega un nuevo objeto Esfera al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialEsfeAgregar(Object obj)
        {
            historialEsferas.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Piramide
        /// </summary>
        /// <returns></returns>
        public ArrayList historialPiraConsultar()
        {
            return historialPiramides;
        }

        /// <summary>
        /// Agrega un nuevo objeto Piramide al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialPiraAgregar(Object obj)
        {
            historialPiramides.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Prisma
        /// </summary>
        /// <returns></returns>
        public ArrayList historialPrisConsultar()
        {
            return historialPrismas;
        }

        /// <summary>
        /// Agrega un nuevo objeto Prisma al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialPrisAgregar(Object obj)
        {
            historialPrismas.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Octaedro
        /// </summary>
        /// <returns></returns>
        public ArrayList historialOctaConsultar()
        {
            return historialOctaedros;
        }


        /// <summary>
        /// Agrega un nuevo objeto Octaedro al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialOctaAgregar(Object obj)
        {
            historialOctaedros.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Ortoedro
        /// </summary>
        /// <returns></returns>
        public ArrayList historialOrtoeConsultar()
        {
            return historialOrtoedros;
        }

        /// <summary>
        /// Agrega un nuevo objeto Ortoedro al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialOrtoeAgregar(Object obj)
        {
            historialOrtoedros.Add(obj);
        }

        /// <summary>
        /// Retorna el historial de objetos Tetraedro
        /// </summary>
        /// <returns></returns>
        public ArrayList historialTetraConsultar()
        {
            return historialTetraedros;
        }

        /// <summary>
        /// Agrega un nuevo objeto Tetraedro al ArrayList de su tipo de historial
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialTetraAgregar(Object obj)
        {
            historialTetraedros.Add(obj);
        }

       
    }

    
}
