
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmPiramide
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResulPir = new System.Windows.Forms.TextBox();
            this.txtApoCara = new System.Windows.Forms.TextBox();
            this.txtApoBase = new System.Windows.Forms.TextBox();
            this.txtAltPir = new System.Windows.Forms.TextBox();
            this.txtLadoBasePir = new System.Windows.Forms.TextBox();
            this.btnPiramide = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIRÁMIDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESULTADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LADO DE LA BASE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "APOTEMA DE LA BASE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "APOTEMA DE UNA CARA";
            // 
            // txtResulPir
            // 
            this.txtResulPir.Location = new System.Drawing.Point(85, 358);
            this.txtResulPir.Name = "txtResulPir";
            this.txtResulPir.Size = new System.Drawing.Size(584, 20);
            this.txtResulPir.TabIndex = 6;
            // 
            // txtApoCara
            // 
            this.txtApoCara.Location = new System.Drawing.Point(85, 168);
            this.txtApoCara.Name = "txtApoCara";
            this.txtApoCara.Size = new System.Drawing.Size(100, 20);
            this.txtApoCara.TabIndex = 7;
            // 
            // txtApoBase
            // 
            this.txtApoBase.Location = new System.Drawing.Point(258, 168);
            this.txtApoBase.Name = "txtApoBase";
            this.txtApoBase.Size = new System.Drawing.Size(100, 20);
            this.txtApoBase.TabIndex = 8;
            // 
            // txtAltPir
            // 
            this.txtAltPir.Location = new System.Drawing.Point(420, 168);
            this.txtAltPir.Name = "txtAltPir";
            this.txtAltPir.Size = new System.Drawing.Size(100, 20);
            this.txtAltPir.TabIndex = 9;
            // 
            // txtLadoBasePir
            // 
            this.txtLadoBasePir.Location = new System.Drawing.Point(569, 168);
            this.txtLadoBasePir.Name = "txtLadoBasePir";
            this.txtLadoBasePir.Size = new System.Drawing.Size(100, 20);
            this.txtLadoBasePir.TabIndex = 10;
            // 
            // btnPiramide
            // 
            this.btnPiramide.Location = new System.Drawing.Point(272, 231);
            this.btnPiramide.Name = "btnPiramide";
            this.btnPiramide.Size = new System.Drawing.Size(237, 42);
            this.btnPiramide.TabIndex = 11;
            this.btnPiramide.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnPiramide.UseVisualStyleBackColor = true;
            this.btnPiramide.Click += new System.EventHandler(this.btnPiramide_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(135, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(512, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Por favor, ingrese datos sin espacios vacíos, use la unidad cm, use una coma para" +
    " decimales";
            // 
            // frmPiramide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPiramide);
            this.Controls.Add(this.txtLadoBasePir);
            this.Controls.Add(this.txtAltPir);
            this.Controls.Add(this.txtApoBase);
            this.Controls.Add(this.txtApoCara);
            this.Controls.Add(this.txtResulPir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPiramide";
            this.Text = "PIRÁMIDE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResulPir;
        private System.Windows.Forms.TextBox txtApoCara;
        private System.Windows.Forms.TextBox txtApoBase;
        private System.Windows.Forms.TextBox txtAltPir;
        private System.Windows.Forms.TextBox txtLadoBasePir;
        private System.Windows.Forms.Button btnPiramide;
        private System.Windows.Forms.Label label7;
    }
}