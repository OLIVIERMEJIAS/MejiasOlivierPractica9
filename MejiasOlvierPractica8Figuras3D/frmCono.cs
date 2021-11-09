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
    public partial class frmCono : Form
    {
        Global glob = new Global();
        public frmCono()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen del cono, basados 
        /// en el radio de la figura, la generatirz, y la altura de la figura,
        /// toma en cuenta excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCono_Click(object sender, EventArgs e)
        {
            try
            {
                Cono con = new Cono(double.Parse(txtRadCon.Text), 
                    double.Parse(txtGenCon.Text),double.Parse(txtAltCon.Text), "Cono");
                con.setDatosEnCadena($"Radio: {con.getRadio()}. " +
                    $"Generatriz: {con.getGeneratriz()}. Altura: {con.getAltura()}.");
                txtResulCon.Text = con.mensajeCalculos(con.calcularArea(),con.calcularVolumen());
                glob.historialesAgregar(con);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
