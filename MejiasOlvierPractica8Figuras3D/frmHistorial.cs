using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MejiasOlvierPractica8Figuras3D
{
    public partial class frmHistorial : Form
    {
        Global glob = new Global();
        public frmHistorial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Construye y llena el ListView de este formulario, 
        /// según estén con al menos 1 elemento cada arraylist de 
        /// cada historial de cada figura, en todas las figuras se
        /// muestra por item, tipo, área, volumen y según cada figura
        /// en específico el números de datos que requirieron los cálculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            lvwHistorial.Items.Clear();

            if (glob.getHistorial().Count != 0)
            {
                foreach (Figura fig in glob.getHistorial())
                {
                    ListViewItem listItem = new ListViewItem(fig.getTipo());
                    listItem.SubItems.Add(Math.Round(fig.calcularArea(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(fig.calcularVolumen(), 2).ToString());
                    listItem.SubItems.Add(fig.getDatosEnCadena());
                    lvwHistorial.Items.Add(listItem);

                }
            }

            
        }
    }
}
