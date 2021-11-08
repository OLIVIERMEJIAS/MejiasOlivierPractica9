
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmCilindro
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
            this.btnCli = new System.Windows.Forms.Button();
            this.txtAltCil = new System.Windows.Forms.TextBox();
            this.txtRadCil = new System.Windows.Forms.TextBox();
            this.txtResulCil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCli
            // 
            this.btnCli.Location = new System.Drawing.Point(271, 197);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(199, 63);
            this.btnCli.TabIndex = 0;
            this.btnCli.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnCli.UseVisualStyleBackColor = true;
            this.btnCli.Click += new System.EventHandler(this.btnCli_Click);
            // 
            // txtAltCil
            // 
            this.txtAltCil.Location = new System.Drawing.Point(472, 130);
            this.txtAltCil.Name = "txtAltCil";
            this.txtAltCil.Size = new System.Drawing.Size(100, 20);
            this.txtAltCil.TabIndex = 1;
            // 
            // txtRadCil
            // 
            this.txtRadCil.Location = new System.Drawing.Point(149, 130);
            this.txtRadCil.Name = "txtRadCil";
            this.txtRadCil.Size = new System.Drawing.Size(100, 20);
            this.txtRadCil.TabIndex = 2;
            // 
            // txtResulCil
            // 
            this.txtResulCil.Location = new System.Drawing.Point(119, 379);
            this.txtResulCil.Name = "txtResulCil";
            this.txtResulCil.Size = new System.Drawing.Size(521, 20);
            this.txtResulCil.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CILINDRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RADIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ALTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RESULTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(116, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(512, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Por favor, ingrese datos sin espacios vacíos, use la unidad cm, use una coma para" +
    " decimales";
            // 
            // frmCilindro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResulCil);
            this.Controls.Add(this.txtRadCil);
            this.Controls.Add(this.txtAltCil);
            this.Controls.Add(this.btnCli);
            this.Name = "frmCilindro";
            this.Text = "CILINDRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCli;
        private System.Windows.Forms.TextBox txtAltCil;
        private System.Windows.Forms.TextBox txtRadCil;
        private System.Windows.Forms.TextBox txtResulCil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}