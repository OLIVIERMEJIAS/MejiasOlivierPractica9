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
    public partial class frmOrtoedro : Form
    {
        Global glob = new Global();
        public frmOrtoedro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen del ortoedro, basados 
        /// en el largo, ancho y altura de la figura, toma en cuenta 
        /// excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnOrt_Click(object sender, EventArgs e)
        {
            try
            {
                Ortoedro ortoe = new Ortoedro(double.Parse(txtLarOrt.Text),
                    double.Parse(txtAchOrt.Text), double.Parse(txtAltOrt.Text),
                    "Ortoedro");
                txtResulOrt.Text = ortoe.mensajeCalculos(ortoe.calcularArea(),ortoe.calcularVolumen());
                ortoe.setDatosEnCadena($"Largo: {ortoe.Largo}. Ancho: {ortoe.Ancho}. Altura: {ortoe.Altura}.");
                glob.historialesAgregar(ortoe);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
