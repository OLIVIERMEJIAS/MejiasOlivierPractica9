
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmFiguras3D
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslAreaVol = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.figuras3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsEsfera = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPris = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOrt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTet = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsVerHist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAreaVol,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.tslSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslAreaVol
            // 
            this.tslAreaVol.Name = "tslAreaVol";
            this.tslAreaVol.Size = new System.Drawing.Size(136, 22);
            this.tslAreaVol.Text = "Calcular Área y Volumen";
            this.tslAreaVol.Click += new System.EventHandler(this.tslAreaVol_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSalir
            // 
            this.tslSalir.ForeColor = System.Drawing.Color.Red;
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(29, 22);
            this.tslSalir.Text = "Salir";
            this.tslSalir.Click += new System.EventHandler(this.tslSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.figuras3DToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnsSalir
            // 
            this.mnsSalir.Name = "mnsSalir";
            this.mnsSalir.Size = new System.Drawing.Size(96, 22);
            this.mnsSalir.Text = "Salir";
            this.mnsSalir.Click += new System.EventHandler(this.mnsSalir_Click);
            // 
            // figuras3DToolStripMenuItem
            // 
            this.figuras3DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCil,
            this.mnsCon,
            this.mnsCub,
            this.mnsEsfera,
            this.mnsPir,
            this.mnsPris,
            this.mnsOct,
            this.mnsOrt,
            this.mnsTet});
            this.figuras3DToolStripMenuItem.Name = "figuras3DToolStripMenuItem";
            this.figuras3DToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.figuras3DToolStripMenuItem.Text = "Figuras 3D";
            // 
            // mnsCil
            // 
            this.mnsCil.Name = "mnsCil";
            this.mnsCil.Size = new System.Drawing.Size(166, 22);
            this.mnsCil.Text = "Cilindro";
            this.mnsCil.Click += new System.EventHandler(this.mnsCil_Click);
            // 
            // mnsCon
            // 
            this.mnsCon.Name = "mnsCon";
            this.mnsCon.Size = new System.Drawing.Size(166, 22);
            this.mnsCon.Text = "Cono";
            this.mnsCon.Click += new System.EventHandler(this.mnsCon_Click);
            // 
            // mnsCub
            // 
            this.mnsCub.Name = "mnsCub";
            this.mnsCub.Size = new System.Drawing.Size(166, 22);
            this.mnsCub.Text = "Cubo";
            this.mnsCub.Click += new System.EventHandler(this.mnsCub_Click);
            // 
            // mnsEsfera
            // 
            this.mnsEsfera.Name = "mnsEsfera";
            this.mnsEsfera.Size = new System.Drawing.Size(166, 22);
            this.mnsEsfera.Text = "Esfera";
            this.mnsEsfera.Click += new System.EventHandler(this.mnsEsfera_Click);
            // 
            // mnsPir
            // 
            this.mnsPir.Name = "mnsPir";
            this.mnsPir.Size = new System.Drawing.Size(166, 22);
            this.mnsPir.Text = "Pirámide";
            this.mnsPir.Click += new System.EventHandler(this.mnsPir_Click);
            // 
            // mnsPris
            // 
            this.mnsPris.Name = "mnsPris";
            this.mnsPris.Size = new System.Drawing.Size(166, 22);
            this.mnsPris.Text = "Prisma Recto";
            this.mnsPris.Click += new System.EventHandler(this.mnsPris_Click);
            // 
            // mnsOct
            // 
            this.mnsOct.Name = "mnsOct";
            this.mnsOct.Size = new System.Drawing.Size(166, 22);
            this.mnsOct.Text = "Octaedro Regular";
            this.mnsOct.Click += new System.EventHandler(this.mnsOct_Click);
            // 
            // mnsOrt
            // 
            this.mnsOrt.Name = "mnsOrt";
            this.mnsOrt.Size = new System.Drawing.Size(166, 22);
            this.mnsOrt.Text = "Ortoedro";
            this.mnsOrt.Click += new System.EventHandler(this.mnsOrt_Click);
            // 
            // mnsTet
            // 
            this.mnsTet.Name = "mnsTet";
            this.mnsTet.Size = new System.Drawing.Size(166, 22);
            this.mnsTet.Text = "Tetraedro Regular";
            this.mnsTet.Click += new System.EventHandler(this.mnsTet_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsVerHist});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // mnsVerHist
            // 
            this.mnsVerHist.Name = "mnsVerHist";
            this.mnsVerHist.Size = new System.Drawing.Size(137, 22);
            this.mnsVerHist.Text = "Ver Historial";
            this.mnsVerHist.Click += new System.EventHandler(this.mnsVerHist_Click);
            // 
            // frmFiguras3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFiguras3D";
            this.Text = "ÁREA - VOLUMEN DE FIGURAS 3D";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslAreaVol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsSalir;
        private System.Windows.Forms.ToolStripMenuItem figuras3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsEsfera;
        private System.Windows.Forms.ToolStripMenuItem mnsPir;
        private System.Windows.Forms.ToolStripMenuItem mnsTet;
        private System.Windows.Forms.ToolStripMenuItem mnsOct;
        private System.Windows.Forms.ToolStripMenuItem mnsCub;
        private System.Windows.Forms.ToolStripMenuItem mnsCil;
        private System.Windows.Forms.ToolStripMenuItem mnsOrt;
        private System.Windows.Forms.ToolStripMenuItem mnsPris;
        private System.Windows.Forms.ToolStripMenuItem mnsCon;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnsVerHist;
    }
}

