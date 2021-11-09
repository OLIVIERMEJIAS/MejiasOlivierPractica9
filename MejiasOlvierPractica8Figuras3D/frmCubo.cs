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
    public partial class frmCubo : Form
    {
        Global glob = new Global();
        public frmCubo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calcula el área y volumen del cubo, basados 
        /// en una lado de la figura, toma en cuenta 
        /// excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCubo_Click(object sender, EventArgs e)
        {
            try
            {
                Cubo cub = new Cubo(double.Parse(txtLadCub.Text), "Cubo");
                cub.setDatosEnCadena($"Lado: {cub.getLado()}.");
                txtResulCub.Text = cub.mensajeCalculos(cub.calcularArea(),cub.calcularVolumen());
                glob.historialesAgregar(cub);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
