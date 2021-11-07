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
    public partial class frmEsfera : Form
    {
        Global glob = new Global();
        public frmEsfera()
        {
            InitializeComponent();
        }

        private void btnEsfera_Click(object sender, EventArgs e)
        {
            try
            {
                Esfera esfe = new Esfera(double.Parse(txtRadEsf.Text), "Esfera");
                esfe.calcularArea();
                esfe.calcularVolumen();
                txtResulEsf.Text = esfe.mensajeCalculos();
                glob.historialEsfeAgregar(esfe);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
