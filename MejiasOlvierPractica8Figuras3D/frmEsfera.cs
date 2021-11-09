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
    public partial class frmEsfera : Form
    {
        Global glob = new Global();
        public frmEsfera()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen de la esfera, basados 
        /// en el radio de la figura, toma en cuenta 
        /// excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnEsfera_Click(object sender, EventArgs e)
        {
            try
            {
                Esfera esfe = new Esfera(double.Parse(txtRadEsf.Text), "Esfera");
                txtResulEsf.Text = esfe.mensajeCalculos(esfe.calcularArea(),esfe.calcularVolumen());
                esfe.setDatosEnCadena($"Radio : {esfe.Radio}.");
                glob.historialesAgregar(esfe);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
