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
    public partial class frmPiramide : Form
    {
        Global glob = new Global();
        public frmPiramide()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen de la pirámide, basados 
        /// en la apotema de la base, apotema de una cara, la altura y
        /// lado de la base de la figura, toma en cuenta 
        /// excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnPiramide_Click(object sender, EventArgs e)
        {
            try
            {
                Piramide pira = new Piramide(double.Parse(txtApoBase.Text),
                    double.Parse(txtApoCara.Text), double.Parse(txtAltPir.Text), 
                    double.Parse(txtLadoBasePir.Text), "Pirámide");
                pira.setDatosEnCadena($"Apotema de la base: {pira.ApotemaBase}. " +
                    $"Apotema de una cara: {pira.ApotemaLado}. Altura: {pira.Altura}. " +
                    $"Lado de la base: {pira.LadoBase}.");
                txtResulPir.Text = pira.mensajeCalculos(pira.calcularArea(),pira.calcularVolumen());
                glob.historialesAgregar(pira);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
