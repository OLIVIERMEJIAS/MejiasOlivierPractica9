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

        private void btnOrt_Click(object sender, EventArgs e)
        {
            try
            {
                Ortoedro ortoe = new Ortoedro(double.Parse(txtLarOrt.Text),
                    double.Parse(label2.Text), double.Parse(txtAltOrt.Text),
                    "Ortoedro");
                ortoe.calcularArea();
                ortoe.calcularVolumen();
                txtResulOrt.Text = ortoe.mensajeCalculos();
                glob.historialOrtoeAgregar(ortoe);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
