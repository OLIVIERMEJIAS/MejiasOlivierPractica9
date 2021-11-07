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

        private void btnPiramide_Click(object sender, EventArgs e)
        {
            try
            {
                Piramide pira = new Piramide(double.Parse(txtApoBase.Text),
                    double.Parse(txtApoCara.Text), double.Parse(txtAltPir.Text), 
                    double.Parse(txtLadoBasePir.Text), "Pirámide");
                pira.calcularArea();
                pira.calcularVolumen();
                txtResulPir.Text = pira.mensajeCalculos();
                glob.historialPiraAgregar(pira);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
