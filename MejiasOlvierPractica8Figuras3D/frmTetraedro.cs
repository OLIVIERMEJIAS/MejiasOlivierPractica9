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
    public partial class frmTetraedro : Form
    {
        Global glob = new Global();
        public frmTetraedro()
        {
            InitializeComponent();
        }

        private void btnTetra_Click(object sender, EventArgs e)
        {
            try
            {
                Tetraedro tetra = new Tetraedro(double.Parse(txtArTet.Text), "Tetraedro Regular");
                tetra.calcularArea();
                tetra.calcularVolumen();
                txtResulTet.Text = tetra.mensajeCalculos();
                glob.historialTetraAgregar(tetra);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
