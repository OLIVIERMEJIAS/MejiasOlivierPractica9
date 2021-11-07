
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmEsfera
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
            this.txtRadEsf = new System.Windows.Forms.TextBox();
            this.txtResulEsf = new System.Windows.Forms.TextBox();
            this.btnEsfera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESFERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RADIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESULTADO";
            // 
            // txtRadEsf
            // 
            this.txtRadEsf.Location = new System.Drawing.Point(338, 177);
            this.txtRadEsf.Name = "txtRadEsf";
            this.txtRadEsf.Size = new System.Drawing.Size(100, 20);
            this.txtRadEsf.TabIndex = 3;
            // 
            // txtResulEsf
            // 
            this.txtResulEsf.Location = new System.Drawing.Point(117, 372);
            this.txtResulEsf.Name = "txtResulEsf";
            this.txtResulEsf.Size = new System.Drawing.Size(540, 20);
            this.txtResulEsf.TabIndex = 4;
            // 
            // btnEsfera
            // 
            this.btnEsfera.Location = new System.Drawing.Point(287, 231);
            this.btnEsfera.Name = "btnEsfera";
            this.btnEsfera.Size = new System.Drawing.Size(216, 48);
            this.btnEsfera.TabIndex = 5;
            this.btnEsfera.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnEsfera.UseVisualStyleBackColor = true;
            this.btnEsfera.Click += new System.EventHandler(this.btnEsfera_Click);
            // 
            // frmEsfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsfera);
            this.Controls.Add(this.txtResulEsf);
            this.Controls.Add(this.txtRadEsf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEsfera";
            this.Text = "frmEsfera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadEsf;
        private System.Windows.Forms.TextBox txtResulEsf;
        private System.Windows.Forms.Button btnEsfera;
    }
}