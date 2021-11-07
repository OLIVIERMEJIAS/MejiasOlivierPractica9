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
    public partial class frmFiguras3D : Form
    {
        frmCilindro cili;
        frmCono cono;
        frmCubo cubo;
        frmEsfera esfe;
        frmOctaedro octa;
        frmOrtoedro orto;
        frmPiramide pira;
        frmPrisma pris;
        frmTetraedro tetra;
        frmHistorial histo;

        public frmFiguras3D()
        {
            InitializeComponent();
        }

        private void mnsEsfera_Click(object sender, EventArgs e)
        {
           
            if (esfe == null)
            {
                esfe = new frmEsfera();//instanciar
                esfe.MdiParent = this;
                //delegado
                esfe.FormClosed += new FormClosedEventHandler(cerrarEsfera);
                esfe.Show();
            }
            else
                esfe.Activate();
        }
        private void cerrarEsfera(object sender, FormClosedEventArgs e)
        {
                esfe = null;
        }

        private void cerrarPiramide(object sender, FormClosedEventArgs e)
        {
            pira = null;
        }

        private void cerrarTetraedro(object sender, FormClosedEventArgs e)
        {
            tetra = null;
        }

        private void cerrarOrtoedro(object sender, FormClosedEventArgs e)
        {
            orto = null;
        }

        private void cerrarOctaedro(object sender, FormClosedEventArgs e)
        {
            octa = null;
        }

        private void cerrarCilindro(object sender, FormClosedEventArgs e)
        {
            cili = null;
        }

        private void cerrarCubo(object sender, FormClosedEventArgs e)
        {
            cubo = null;
        }

        private void cerrarPrisma(object sender, FormClosedEventArgs e)
        {
            pris = null;
        }

        private void cerrarCono(object sender, FormClosedEventArgs e)
        {
            cono = null;
        }

        private void mnsPir_Click(object sender, EventArgs e)
        {
            if (pira == null)
            {
                pira = new frmPiramide();//instanciar
                pira.MdiParent = this;
                //delegado
                pira.FormClosed += new FormClosedEventHandler(cerrarPiramide);
                pira.Show();
            }
            else
                pira.Activate();
        }

        private void mnsTet_Click(object sender, EventArgs e)
        {
            if (tetra == null)
            {
                tetra = new frmTetraedro();//instanciar
                tetra.MdiParent = this;
                //delegado
                tetra.FormClosed += new FormClosedEventHandler(cerrarTetraedro);
                tetra.Show();
            }
            else
                tetra.Activate();
        }

        private void mnsOct_Click(object sender, EventArgs e)
        {
            if (octa == null)
            {
                octa = new frmOctaedro();//instanciar
                octa.MdiParent = this;
                //delegado
                octa.FormClosed += new FormClosedEventHandler(cerrarOctaedro);
                octa.Show();
            }
            else
                octa.Activate();
        }

        private void mnsCub_Click(object sender, EventArgs e)
        {
            if (cubo == null)
            {
                cubo = new frmCubo();//instanciar
                cubo.MdiParent = this;
                //delegado
                cubo.FormClosed += new FormClosedEventHandler(cerrarCubo);
                cubo.Show();
            }
            else
                cubo.Activate();
        }

        private void mnsCil_Click(object sender, EventArgs e)
        {
            if (cili == null)
            {
                cili = new frmCilindro();//instanciar
                cili.MdiParent = this;
                //delegado
                cili.FormClosed += new FormClosedEventHandler(cerrarCilindro);
                cili.Show();
            }
            else
                cili.Activate();
        }

        private void mnsOrt_Click(object sender, EventArgs e)
        {
            if (orto == null)
            {
                orto = new frmOrtoedro();//instanciar
                orto.MdiParent = this;
                //delegado
                orto.FormClosed += new FormClosedEventHandler(cerrarOrtoedro);
                orto.Show();
            }
            else
                orto.Activate();
        }

        private void mnsPris_Click(object sender, EventArgs e)
        {
            if (pris == null)
            {
                pris = new frmPrisma();//instanciar
                pris.MdiParent = this;
                //delegado
                pris.FormClosed += new FormClosedEventHandler(cerrarPrisma);
                pris.Show();
            }
            else
                pris.Activate();
        }

        private void mnsCon_Click(object sender, EventArgs e)
        {
            if (cono == null)
            {
                cono = new frmCono();//instanciar
                cono.MdiParent = this;
                //delegado
                cono.FormClosed += new FormClosedEventHandler(cerrarCono);
                cono.Show();
            }
            else
                cono.Activate();
        }

        private void cerrarHisto(object sender, FormClosedEventArgs e)
        {
            histo = null;
        }

        private void mnsVerHist_Click(object sender, EventArgs e)
        {
            if (histo == null)
            {
                histo = new frmHistorial();//instanciar
                histo.MdiParent = this;
                //delegado
                histo.FormClosed += new FormClosedEventHandler(cerrarHisto);
                histo.Show();
            }
            else
                histo.Activate();
        }
    }
}
