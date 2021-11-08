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
        //instancias de todos los formularios que usa la aplicación
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

        /// <summary>
        /// Crea un formulario para la esfera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Aporta al evento FormClosed del formulario Esfera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarEsfera(object sender, FormClosedEventArgs e)
        {
                esfe = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Piramide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarPiramide(object sender, FormClosedEventArgs e)
        {
            pira = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Tetraedro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarTetraedro(object sender, FormClosedEventArgs e)
        {
            tetra = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Ortoedro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarOrtoedro(object sender, FormClosedEventArgs e)
        {
            orto = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Octaedro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarOctaedro(object sender, FormClosedEventArgs e)
        {
            octa = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Cilindro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarCilindro(object sender, FormClosedEventArgs e)
        {
            cili = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Cubo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarCubo(object sender, FormClosedEventArgs e)
        {
            cubo = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Prisma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarPrisma(object sender, FormClosedEventArgs e)
        {
            pris = null;
        }

        /// <summary>
        /// Aporta al evento FormClosed del formulario Cono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarCono(object sender, FormClosedEventArgs e)
        {
            cono = null;
        }

        /// <summary>
        /// Crea un formulario para la pirámide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el tetraedro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el octaedro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el cubo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el cilindro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el ortoedro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el prisma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea un formulario para el cono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Aporta al evento FormClosed del formulario Historial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarHisto(object sender, FormClosedEventArgs e)
        {
            histo = null;
        }

        /// <summary>
        /// Crea un formulario para el historial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Llama a la ejecución del evento click del botón calcular
        /// de cada formulario de uan figura en específico que su 
        /// formulario no sea null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslAreaVol_Click(object sender, EventArgs e)
        {
            if (cili != null)
                cili.btnCli_Click(sender, e);
            else if (cono != null)
                cono.btnCono_Click(sender, e);
            else if (cubo != null)
                cubo.btnCubo_Click(sender, e);
            else if (esfe != null)
                esfe.btnEsfera_Click(sender, e);
            else if (pira != null)
                pira.btnPiramide_Click(sender, e);
            else if (pris != null)
                pris.btnPrisma_Click(sender, e);
            else if (octa != null)
                octa.btnOct_Click(sender, e);
            else if (orto != null)
                orto.btnOrt_Click(sender, e);
            else if (tetra != null)
                tetra.btnTetra_Click(sender, e);


        }
        /// <summary>
        /// Cierra la aplicación desde el menú de herramientas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cierra la aplicación desde la barra de menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
