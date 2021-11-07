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
    public partial class frmCono : Form
    {
        Global glob = new Global();
        public frmCono()
        {
            InitializeComponent();
        }

        private void btnCono_Click(object sender, EventArgs e)
        {
            try
            {
                Cono con = new Cono(double.Parse(txtRadCon.Text), 
                    double.Parse(txtGenCon.Text),double.Parse(txtAltCon.Text), "Cono");
                con.calcularArea();
                con.calcularVolumen();
                txtResulCon.Text = con.mensajeCalculos();
                glob.historialConoAgregar(con);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Has ingresado un formato invalido de datos!!");
            }
        }
    }
}
