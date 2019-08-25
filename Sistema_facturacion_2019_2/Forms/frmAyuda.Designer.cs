namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmAyuda
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAySalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAyEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsDatosAdicionales = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(337, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "A Y U D A";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtUsDatosAdicionales);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(44, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 269);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.btnAySalir);
            this.panel2.Controls.Add(this.btnAyEnviar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 267);
            this.panel2.TabIndex = 7;
            // 
            // btnAySalir
            // 
            this.btnAySalir.AutoSize = true;
            this.btnAySalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAySalir.Depth = 0;
            this.btnAySalir.FlatAppearance.BorderSize = 0;
            this.btnAySalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAySalir.Icon = null;
            this.btnAySalir.Location = new System.Drawing.Point(55, 137);
            this.btnAySalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAySalir.Name = "btnAySalir";
            this.btnAySalir.Primary = true;
            this.btnAySalir.Size = new System.Drawing.Size(72, 36);
            this.btnAySalir.TabIndex = 4;
            this.btnAySalir.Text = "S A L I R";
            this.btnAySalir.UseVisualStyleBackColor = true;
            this.btnAySalir.Click += new System.EventHandler(this.BtnAySalir_Click);
            // 
            // btnAyEnviar
            // 
            this.btnAyEnviar.AutoSize = true;
            this.btnAyEnviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAyEnviar.Depth = 0;
            this.btnAyEnviar.FlatAppearance.BorderSize = 0;
            this.btnAyEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAyEnviar.Icon = null;
            this.btnAyEnviar.Location = new System.Drawing.Point(48, 85);
            this.btnAyEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAyEnviar.Name = "btnAyEnviar";
            this.btnAyEnviar.Primary = true;
            this.btnAyEnviar.Size = new System.Drawing.Size(86, 36);
            this.btnAyEnviar.TabIndex = 1;
            this.btnAyEnviar.Text = "E N V I A R";
            this.btnAyEnviar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(19, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Solicitar Ayuda:";
            // 
            // txtUsDatosAdicionales
            // 
            this.txtUsDatosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.txtUsDatosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsDatosAdicionales.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsDatosAdicionales.Location = new System.Drawing.Point(22, 72);
            this.txtUsDatosAdicionales.Multiline = true;
            this.txtUsDatosAdicionales.Name = "txtUsDatosAdicionales";
            this.txtUsDatosAdicionales.Size = new System.Drawing.Size(481, 149);
            this.txtUsDatosAdicionales.TabIndex = 27;
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(813, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyuda";
            this.Text = "frmAyuda";
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
        private MaterialSkin.Controls.MaterialRaisedButton btnAySalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnAyEnviar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsDatosAdicionales;
    }
}