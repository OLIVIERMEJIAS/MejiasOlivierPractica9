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

        private void btnCubo_Click(object sender, EventArgs e)
        {
            try
            {
                Cubo cub = new Cubo(double.Parse(txtLadCub.Text), "Cubo");
                cub.calcularArea();
                cub.calcularVolumen();
                txtResulCub.Text = cub.mensajeCalculos();
                glob.historialCuboAgregar(cub);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
