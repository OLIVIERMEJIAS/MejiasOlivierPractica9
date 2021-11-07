
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmOrtoedro
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
            this.btnOrt = new System.Windows.Forms.Button();
            this.txtResulOrt = new System.Windows.Forms.TextBox();
            this.txtAltOrt = new System.Windows.Forms.TextBox();
            this.txtAchOrt = new System.Windows.Forms.TextBox();
            this.txtLarOrt = new System.Windows.Forms.TextBox();
            this.laber1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrt
            // 
            this.btnOrt.Location = new System.Drawing.Point(266, 202);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(265, 63);
            this.btnOrt.TabIndex = 0;
            this.btnOrt.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.btnOrt_Click);
            // 
            // txtResulOrt
            // 
            this.txtResulOrt.Location = new System.Drawing.Point(133, 346);
            this.txtResulOrt.Name = "txtResulOrt";
            this.txtResulOrt.Size = new System.Drawing.Size(531, 20);
            this.txtResulOrt.TabIndex = 1;
            // 
            // txtAltOrt
            // 
            this.txtAltOrt.Location = new System.Drawing.Point(536, 122);
            this.txtAltOrt.Name = "txtAltOrt";
            this.txtAltOrt.Size = new System.Drawing.Size(100, 20);
            this.txtAltOrt.TabIndex = 2;
            // 
            // txtAchOrt
            // 
            this.txtAchOrt.Location = new System.Drawing.Point(341, 122);
            this.txtAchOrt.Name = "txtAchOrt";
            this.txtAchOrt.Size = new System.Drawing.Size(100, 20);
            this.txtAchOrt.TabIndex = 3;
            // 
            // txtLarOrt
            // 
            this.txtLarOrt.Location = new System.Drawing.Point(153, 122);
            this.txtLarOrt.Name = "txtLarOrt";
            this.txtLarOrt.Size = new System.Drawing.Size(100, 20);
            this.txtLarOrt.TabIndex = 4;
            // 
            // laber1
            // 
            this.laber1.AutoSize = true;
            this.laber1.Location = new System.Drawing.Point(359, 45);
            this.laber1.Name = "laber1";
            this.laber1.Size = new System.Drawing.Size(69, 13);
            this.laber1.TabIndex = 5;
            this.laber1.Text = "ORTOEDRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LARGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ANCHO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ALTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RESULTADO";
            // 
            // frmOrtoedro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laber1);
            this.Controls.Add(this.txtLarOrt);
            this.Controls.Add(this.txtAchOrt);
            this.Controls.Add(this.txtAltOrt);
            this.Controls.Add(this.txtResulOrt);
            this.Controls.Add(this.btnOrt);
            this.Name = "frmOrtoedro";
            this.Text = "frmOrtoedro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrt;
        private System.Windows.Forms.TextBox txtResulOrt;
        private System.Windows.Forms.TextBox txtAltOrt;
        private System.Windows.Forms.TextBox txtAchOrt;
        private System.Windows.Forms.TextBox txtLarOrt;
        private System.Windows.Forms.Label laber1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}