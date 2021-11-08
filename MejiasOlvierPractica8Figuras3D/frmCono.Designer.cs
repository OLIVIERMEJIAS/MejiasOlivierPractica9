
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmCono
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
            this.txtResulCon = new System.Windows.Forms.TextBox();
            this.txtAltCon = new System.Windows.Forms.TextBox();
            this.txtGenCon = new System.Windows.Forms.TextBox();
            this.txtRadCon = new System.Windows.Forms.TextBox();
            this.btnCono = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENERATRIZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RADIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RESULTADO";
            // 
            // txtResulCon
            // 
            this.txtResulCon.Location = new System.Drawing.Point(95, 373);
            this.txtResulCon.Name = "txtResulCon";
            this.txtResulCon.Size = new System.Drawing.Size(628, 20);
            this.txtResulCon.TabIndex = 5;
            // 
            // txtAltCon
            // 
            this.txtAltCon.Location = new System.Drawing.Point(557, 177);
            this.txtAltCon.Name = "txtAltCon";
            this.txtAltCon.Size = new System.Drawing.Size(100, 20);
            this.txtAltCon.TabIndex = 6;
            // 
            // txtGenCon
            // 
            this.txtGenCon.Location = new System.Drawing.Point(350, 177);
            this.txtGenCon.Name = "txtGenCon";
            this.txtGenCon.Size = new System.Drawing.Size(100, 20);
            this.txtGenCon.TabIndex = 7;
            // 
            // txtRadCon
            // 
            this.txtRadCon.Location = new System.Drawing.Point(115, 177);
            this.txtRadCon.Name = "txtRadCon";
            this.txtRadCon.Size = new System.Drawing.Size(100, 20);
            this.txtRadCon.TabIndex = 8;
            // 
            // btnCono
            // 
            this.btnCono.Location = new System.Drawing.Point(261, 239);
            this.btnCono.Name = "btnCono";
            this.btnCono.Size = new System.Drawing.Size(283, 53);
            this.btnCono.TabIndex = 9;
            this.btnCono.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnCono.UseVisualStyleBackColor = true;
            this.btnCono.Click += new System.EventHandler(this.btnCono_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(133, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Por favor, ingrese datos sin espacios vacíos, use la unidad cm, use una coma para" +
    " decimales";
            // 
            // frmCono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCono);
            this.Controls.Add(this.txtRadCon);
            this.Controls.Add(this.txtGenCon);
            this.Controls.Add(this.txtAltCon);
            this.Controls.Add(this.txtResulCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCono";
            this.Text = "CONO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResulCon;
        private System.Windows.Forms.TextBox txtAltCon;
        private System.Windows.Forms.TextBox txtGenCon;
        private System.Windows.Forms.TextBox txtRadCon;
        private System.Windows.Forms.Button btnCono;
        private System.Windows.Forms.Label label6;
    }
}