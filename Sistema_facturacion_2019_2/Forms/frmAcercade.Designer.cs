namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmAcercade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcInformacion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(306, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "A C E R C A  D E";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAcInformacion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 269);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Información:";
            // 
            // txtAcInformacion
            // 
            this.txtAcInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.txtAcInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcInformacion.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcInformacion.Location = new System.Drawing.Point(32, 91);
            this.txtAcInformacion.Multiline = true;
            this.txtAcInformacion.Name = "txtAcInformacion";
            this.txtAcInformacion.Size = new System.Drawing.Size(469, 120);
            this.txtAcInformacion.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.btnAcSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 267);
            this.panel2.TabIndex = 7;
            // 
            // btnAcSalir
            // 
            this.btnAcSalir.AutoSize = true;
            this.btnAcSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcSalir.Depth = 0;
            this.btnAcSalir.FlatAppearance.BorderSize = 0;
            this.btnAcSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAcSalir.Icon = null;
            this.btnAcSalir.Location = new System.Drawing.Point(57, 175);
            this.btnAcSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcSalir.Name = "btnAcSalir";
            this.btnAcSalir.Primary = true;
            this.btnAcSalir.Size = new System.Drawing.Size(72, 36);
            this.btnAcSalir.TabIndex = 4;
            this.btnAcSalir.Text = "S A L I R";
            this.btnAcSalir.UseVisualStyleBackColor = true;
            this.btnAcSalir.Click += new System.EventHandler(this.BtnAcSalir_Click);
            // 
            // frmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(947, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcercade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnAcSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcInformacion;
    }
}