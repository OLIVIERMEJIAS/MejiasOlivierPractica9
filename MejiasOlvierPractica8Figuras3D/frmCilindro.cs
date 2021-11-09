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
    public partial class frmCilindro : Form
    {
        Global glob = new Global();
        public frmCilindro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen del cilindro, basados 
        /// en el radio y en la altura de la figura, toma en cuenta 
        /// excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCli_Click(object sender, EventArgs e)
        {
            try
            {
                Cilindro cili = new Cilindro(double.Parse(txtRadCil.Text),
                    double.Parse(txtAltCil.Text), "Cilindro");
                cili.setDatosEnCadena($"Radio: {cili.getRadio()}. Altura: {cili.getAltura()}.");
                txtResulCil.Text = cili.mensajeCalculos(cili.calcularArea(), cili.calcularVolumen());
                glob.historialesAgregar(cili);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
