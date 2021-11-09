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
        private static ArrayList historiales;

        //Construye un objeto tipo Global, si están en null, los crea
        //todos, como se crean todos o ninguno solo se pregunta el estado de uno
        public Global()
        {
            if (historiales == null)
            {
                historiales = new ArrayList();
            }
        }

        /// <summary>
        /// Retorna el arrayList de historiales en general
        /// </summary>
        /// <returns></returns>
        public ArrayList getHistorial()
        {
            return historiales;
        }

        /// <summary>
        /// Agrega un nuevo objeto al ArrayList de historiales general
        /// </summary>
        /// <remarks>Requiere un objeto como argumento</remarks>
        /// <returns></returns>
        public void historialesAgregar(Object obj)
        {
            historiales.Add(obj);
        }
    }
}

        
