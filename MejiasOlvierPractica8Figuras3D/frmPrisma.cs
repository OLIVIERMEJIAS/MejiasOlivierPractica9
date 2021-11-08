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
    public partial class frmPrisma : Form
    {
        Global glob = new Global();
        public frmPrisma()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el área y volumen del prisma, basados 
        /// en el lado de la base, la apotema de la base y la altura de la figura,
        /// toma en cuenta excepciones. calcularArea y calcularVolumen, 
        /// toman los datos que se guardan en el interior 
        /// del objeto, los mcalculan y los guardan en los
        /// atribuytos de area y volumen. Por último se usa el método: 
        /// mensajeCalculos para enviar un mensaje desde la figura al 
        /// TextBox de este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnPrisma_Click(object sender, EventArgs e)
        {
            try
            {
                Prisma pris = new Prisma(double.Parse(txtLabBasPris.Text),
                    double.Parse(txtApoBasePris.Text), double.Parse(txtAltPris.Text),
                   "Prisma Recto");
                pris.calcularArea();
                pris.calcularVolumen();
                txtResulPrisma.Text = pris.mensajeCalculos();
                glob.historialPrisAgregar(pris);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
