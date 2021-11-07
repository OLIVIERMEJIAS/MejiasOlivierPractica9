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

        private void btnCli_Click(object sender, EventArgs e)
        {
            try
            {
                Cilindro cili = new Cilindro(double.Parse(txtRadCil.Text),double.Parse(txtAltCil.Text), "Cilindro");
                cili.calcularArea();
                cili.calcularVolumen();
                txtResulCil.Text = cili.mensajeCalculos();
                glob.historialCiliAgregar(cili);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
