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

        private void btnOct_Click(object sender, EventArgs e)
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
