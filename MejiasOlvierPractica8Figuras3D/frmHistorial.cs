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
    public partial class frmHistorial : Form
    {
        Global glob = new Global();
        public frmHistorial()
        {
            InitializeComponent();
        }


      
        /// <summary>
        /// Construye y llena el ListView de este formulario, 
        /// según estén con al menos 1 elemento cada arraylist de 
        /// cada historial de cada figura, en todas las figuras se
        /// muestra por item, tipo, área, volumen y según cada figura
        /// en específico el números de datos que requirieron los cálculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            lvwHistorial.Items.Clear();

            if (glob.historialCiliConsultar().Count != 0)
            {
                foreach (Cilindro cili in glob.historialCiliConsultar())
                {
                    ListViewItem listItem = new ListViewItem(cili.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(cili.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(cili.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Radio: {cili.radioConsultar().ToString()}");
                    listItem.SubItems.Add($"Altura: {cili.alturaConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialConoConsultar().Count != 0)
            {
                foreach (Cono con in glob.historialConoConsultar())
                {
                    ListViewItem listItem = new ListViewItem(con.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(con.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(con.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Radio: {con.radioConsultar().ToString()}");
                    listItem.SubItems.Add($"Altura: {con.alturaConsultar().ToString()}");
                    listItem.SubItems.Add($"Generatriz: {con.generatrizConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialCuboConsultar().Count != 0)
            {
                foreach (Cubo cub in glob.historialCuboConsultar())
                {
                    ListViewItem listItem = new ListViewItem(cub.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(cub.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(cub.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Lado: {cub.ladoConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialEsfeConsultar().Count != 0)
            {
                foreach (Esfera esfe in glob.historialEsfeConsultar())
                {
                    ListViewItem listItem = new ListViewItem(esfe.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(esfe.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(esfe.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Radio: {esfe.radioConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialOctaConsultar().Count != 0)
            {
                foreach (Octaedro octa in glob.historialOctaConsultar())
                {
                    ListViewItem listItem = new ListViewItem(octa.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(octa.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(octa.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Arista: {octa.aristaConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialOrtoeConsultar().Count != 0)
            {
                foreach (Ortoedro ortoe in glob.historialOrtoeConsultar())
                {
                    ListViewItem listItem = new ListViewItem(ortoe.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(ortoe.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(ortoe.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Largo: {ortoe.largoConsultar().ToString()}");
                    listItem.SubItems.Add($"Ancho: {ortoe.anchoConsultar().ToString()}");
                    listItem.SubItems.Add($"Altura: {ortoe.alturaConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialPiraConsultar().Count != 0)
            {
                foreach (Piramide pira in glob.historialPiraConsultar())
                {
                    ListViewItem listItem = new ListViewItem(pira.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(pira.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(pira.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Apotema Base: {pira.apotemaBaseConsultar().ToString()}");
                    listItem.SubItems.Add($"Apotema Lado: {pira.apotemaLadoConsultar().ToString()}");
                    listItem.SubItems.Add($"Altura: {pira.alturaConsultar().ToString()}");
                    listItem.SubItems.Add($"Lado Base: {pira.ladoBaseConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialPrisConsultar().Count != 0)
            {
                foreach (Prisma pris in glob.historialPrisConsultar())
                {
                    ListViewItem listItem = new ListViewItem(pris.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(pris.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(pris.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Lado base: {pris.ladoBaseConsultar().ToString()}");
                    listItem.SubItems.Add($"Apotema: {pris.apotemaConsultar().ToString()}");
                    listItem.SubItems.Add($"Altura: {pris.alturaConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }

            if (glob.historialTetraConsultar().Count != 0)
            {
                foreach (Tetraedro tetra in glob.historialTetraConsultar())
                {
                    ListViewItem listItem = new ListViewItem(tetra.tipoConsultar());
                    listItem.SubItems.Add(Math.Round(tetra.areaConsultar(), 2).ToString());
                    listItem.SubItems.Add(Math.Round(tetra.volumenConsultar(), 2).ToString());
                    listItem.SubItems.Add($"Arista: {tetra.aristaConsultar().ToString()}");
                    lvwHistorial.Items.Add(listItem);
                }
            }
        }
    }
}
