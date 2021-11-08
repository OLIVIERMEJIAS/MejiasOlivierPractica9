
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmPrisma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrisma = new System.Windows.Forms.Button();
            this.txtApoBasePris = new System.Windows.Forms.TextBox();
            this.txtLabBasPris = new System.Windows.Forms.TextBox();
            this.txtAltPris = new System.Windows.Forms.TextBox();
            this.txtResulPrisma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRISMA\r\n RECTO";
            // 
            // btnPrisma
            // 
            this.btnPrisma.Location = new System.Drawing.Point(258, 217);
            this.btnPrisma.Name = "btnPrisma";
            this.btnPrisma.Size = new System.Drawing.Size(244, 58);
            this.btnPrisma.TabIndex = 1;
            this.btnPrisma.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnPrisma.UseVisualStyleBackColor = true;
            this.btnPrisma.Click += new System.EventHandler(this.btnPrisma_Click);
            // 
            // txtApoBasePris
            // 
            this.txtApoBasePris.Location = new System.Drawing.Point(117, 129);
            this.txtApoBasePris.Name = "txtApoBasePris";
            this.txtApoBasePris.Size = new System.Drawing.Size(100, 20);
            this.txtApoBasePris.TabIndex = 2;
            // 
            // txtLabBasPris
            // 
            this.txtLabBasPris.Location = new System.Drawing.Point(329, 129);
            this.txtLabBasPris.Name = "txtLabBasPris";
            this.txtLabBasPris.Size = new System.Drawing.Size(100, 20);
            this.txtLabBasPris.TabIndex = 4;
            // 
            // txtAltPris
            // 
            this.txtAltPris.Location = new System.Drawing.Point(529, 129);
            this.txtAltPris.Name = "txtAltPris";
            this.txtAltPris.Size = new System.Drawing.Size(100, 20);
            this.txtAltPris.TabIndex = 5;
            // 
            // txtResulPrisma
            // 
            this.txtResulPrisma.Location = new System.Drawing.Point(89, 367);
            this.txtResulPrisma.Name = "txtResulPrisma";
            this.txtResulPrisma.Size = new System.Drawing.Size(603, 20);
            this.txtResulPrisma.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "APOTEMA DE LA BASE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ALTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "LADO DE LA BASE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RESULTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(117, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Por favor, ingrese datos sin espacios vacíos, use la unidad cm, use una coma para" +
    " decimales";
            // 
            // frmPrisma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResulPrisma);
            this.Controls.Add(this.txtAltPris);
            this.Controls.Add(this.txtLabBasPris);
            this.Controls.Add(this.txtApoBasePris);
            this.Controls.Add(this.btnPrisma);
            this.Controls.Add(this.label1);
            this.Name = "frmPrisma";
            this.Text = "PRISMA RECTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrisma;
        private System.Windows.Forms.TextBox txtApoBasePris;
        private System.Windows.Forms.TextBox txtLabBasPris;
        private System.Windows.Forms.TextBox txtAltPris;
        private System.Windows.Forms.TextBox txtResulPrisma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}