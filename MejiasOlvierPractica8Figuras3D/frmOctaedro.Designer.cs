
namespace MejiasOlvierPractica8Figuras3D
{
    partial class frmOctaedro
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
            this.txtArOct = new System.Windows.Forms.TextBox();
            this.txtResulOct = new System.Windows.Forms.TextBox();
            this.btnOct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "OCTAEDRO\r\n REGULAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESULTADO";
            // 
            // txtArOct
            // 
            this.txtArOct.Location = new System.Drawing.Point(329, 182);
            this.txtArOct.Name = "txtArOct";
            this.txtArOct.Size = new System.Drawing.Size(100, 20);
            this.txtArOct.TabIndex = 3;
            // 
            // txtResulOct
            // 
            this.txtResulOct.Location = new System.Drawing.Point(127, 352);
            this.txtResulOct.Name = "txtResulOct";
            this.txtResulOct.Size = new System.Drawing.Size(532, 20);
            this.txtResulOct.TabIndex = 4;
            // 
            // btnOct
            // 
            this.btnOct.Location = new System.Drawing.Point(279, 221);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(202, 47);
            this.btnOct.TabIndex = 5;
            this.btnOct.Text = "CALCULAR ÁREA Y VOLUMEN";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(124, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Por favor, ingrese datos sin espacios vacíos, use la unidad cm, use una coma para" +
    " decimales";
            // 
            // frmOctaedro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.txtResulOct);
            this.Controls.Add(this.txtArOct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOctaedro";
            this.Text = "OCTAEDRO REGULAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArOct;
        private System.Windows.Forms.TextBox txtResulOct;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Label label4;
    }
}