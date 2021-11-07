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

        private void btnPrisma_Click(object sender, EventArgs e)
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
