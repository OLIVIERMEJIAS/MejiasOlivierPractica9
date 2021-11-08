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
    public partial class frmOctaedro : Form
    {
        Global glob = new Global();
        public frmOctaedro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen del octaedro, basados 
        /// en la arista de la figura, toma en cuenta 
        /// excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnOct_Click(object sender, EventArgs e)
        {
            try
            {
                Octaedro octa = new Octaedro(double.Parse(txtArOct.Text), "Octaedro Regular");
                octa.calcularArea();
                octa.calcularVolumen();
                txtResulOct.Text = octa.mensajeCalculos();
                glob.historialOctaAgregar(octa);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
