
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmCubo
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
            this.btnCubo = new System.Windows.Forms.Button();
            this.txtLadCub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResulCub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCubo
            // 
            this.btnCubo.Location = new System.Drawing.Point(290, 214);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Size = new System.Drawing.Size(181, 58);
            this.btnCubo.TabIndex = 0;
            this.btnCubo.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnCubo.UseVisualStyleBackColor = true;
            this.btnCubo.Click += new System.EventHandler(this.btnCubo_Click);
            // 
            // txtLadCub
            // 
            this.txtLadCub.Location = new System.Drawing.Point(334, 137);
            this.txtLadCub.Name = "txtLadCub";
            this.txtLadCub.Size = new System.Drawing.Size(100, 20);
            this.txtLadCub.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUBO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LADO";
            // 
            // txtResulCub
            // 
            this.txtResulCub.Location = new System.Drawing.Point(121, 372);
            this.txtResulCub.Name = "txtResulCub";
            this.txtResulCub.Size = new System.Drawing.Size(519, 20);
            this.txtResulCub.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RESULTADO";
            // 
            // frmCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResulCub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLadCub);
            this.Controls.Add(this.btnCubo);
            this.Name = "frmCubo";
            this.Text = "CUBO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCubo;
        private System.Windows.Forms.TextBox txtLadCub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResulCub;
        private System.Windows.Forms.Label label3;
    }
}