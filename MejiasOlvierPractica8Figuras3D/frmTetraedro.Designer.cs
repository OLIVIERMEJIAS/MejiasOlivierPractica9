
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmTetraedro
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
            this.txtArTet = new System.Windows.Forms.TextBox();
            this.txtResulTet = new System.Windows.Forms.TextBox();
            this.btnTetra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TETRAEDRO \r\n   REGULAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESULTADO";
            // 
            // txtArTet
            // 
            this.txtArTet.Location = new System.Drawing.Point(335, 180);
            this.txtArTet.Name = "txtArTet";
            this.txtArTet.Size = new System.Drawing.Size(100, 20);
            this.txtArTet.TabIndex = 3;
            // 
            // txtResulTet
            // 
            this.txtResulTet.Location = new System.Drawing.Point(117, 370);
            this.txtResulTet.Name = "txtResulTet";
            this.txtResulTet.Size = new System.Drawing.Size(540, 20);
            this.txtResulTet.TabIndex = 4;
            // 
            // btnTetra
            // 
            this.btnTetra.Location = new System.Drawing.Point(285, 234);
            this.btnTetra.Name = "btnTetra";
            this.btnTetra.Size = new System.Drawing.Size(208, 48);
            this.btnTetra.TabIndex = 5;
            this.btnTetra.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnTetra.UseVisualStyleBackColor = true;
            this.btnTetra.Click += new System.EventHandler(this.btnTetra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(125, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Por favor, ingrese datos sin espacios vacíos, use la unidad cm, use una coma para" +
    " decimales";
            // 
            // frmTetraedro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTetra);
            this.Controls.Add(this.txtResulTet);
            this.Controls.Add(this.txtArTet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTetraedro";
            this.Text = "TETRAEDRO REGULAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArTet;
        private System.Windows.Forms.TextBox txtResulTet;
        private System.Windows.Forms.Button btnTetra;
        private System.Windows.Forms.Label label4;
    }
}