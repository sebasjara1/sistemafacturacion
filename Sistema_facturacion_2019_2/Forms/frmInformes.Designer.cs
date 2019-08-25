namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmInformes
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
            this.cbIfSeleccionarInforme = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFcSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnIfGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIfFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIfFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(305, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "I N F O R M E S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpIfFechaFinal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIfFechaInicial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbIfSeleccionarInforme);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(29, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 269);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seleccionar Informe:";
            // 
            // cbIfSeleccionarInforme
            // 
            this.cbIfSeleccionarInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbIfSeleccionarInforme.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIfSeleccionarInforme.FormattingEnabled = true;
            this.cbIfSeleccionarInforme.Location = new System.Drawing.Point(173, 145);
            this.cbIfSeleccionarInforme.Name = "cbIfSeleccionarInforme";
            this.cbIfSeleccionarInforme.Size = new System.Drawing.Size(326, 21);
            this.cbIfSeleccionarInforme.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel2.Controls.Add(this.btnFcSalir);
            this.panel2.Controls.Add(this.btnIfGenerar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 267);
            this.panel2.TabIndex = 7;
            // 
            // btnFcSalir
            // 
            this.btnFcSalir.AutoSize = true;
            this.btnFcSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFcSalir.Depth = 0;
            this.btnFcSalir.FlatAppearance.BorderSize = 0;
            this.btnFcSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFcSalir.Icon = null;
            this.btnFcSalir.Location = new System.Drawing.Point(52, 133);
            this.btnFcSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcSalir.Name = "btnFcSalir";
            this.btnFcSalir.Primary = true;
            this.btnFcSalir.Size = new System.Drawing.Size(72, 36);
            this.btnFcSalir.TabIndex = 4;
            this.btnFcSalir.Text = "S A L I R";
            this.btnFcSalir.UseVisualStyleBackColor = true;
            this.btnFcSalir.Click += new System.EventHandler(this.BtnFcSalir_Click);
            // 
            // btnIfGenerar
            // 
            this.btnIfGenerar.AutoSize = true;
            this.btnIfGenerar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIfGenerar.Depth = 0;
            this.btnIfGenerar.FlatAppearance.BorderSize = 0;
            this.btnIfGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnIfGenerar.Icon = null;
            this.btnIfGenerar.Location = new System.Drawing.Point(38, 79);
            this.btnIfGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIfGenerar.Name = "btnIfGenerar";
            this.btnIfGenerar.Primary = true;
            this.btnIfGenerar.Size = new System.Drawing.Size(102, 36);
            this.btnIfGenerar.TabIndex = 1;
            this.btnIfGenerar.Text = "G E N E R A R";
            this.btnIfGenerar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(14, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Inicial:";
            // 
            // dtpIfFechaInicial
            // 
            this.dtpIfFechaInicial.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpIfFechaInicial.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIfFechaInicial.Location = new System.Drawing.Point(122, 79);
            this.dtpIfFechaInicial.Name = "dtpIfFechaInicial";
            this.dtpIfFechaInicial.Size = new System.Drawing.Size(377, 22);
            this.dtpIfFechaInicial.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha Final:";
            // 
            // dtpIfFechaFinal
            // 
            this.dtpIfFechaFinal.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpIfFechaFinal.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIfFechaFinal.Location = new System.Drawing.Point(122, 111);
            this.dtpIfFechaFinal.Name = "dtpIfFechaFinal";
            this.dtpIfFechaFinal.Size = new System.Drawing.Size(377, 22);
            this.dtpIfFechaFinal.TabIndex = 23;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(934, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIfSeleccionarInforme;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnFcSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnIfGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIfFechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIfFechaInicial;
    }
}