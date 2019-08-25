namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmSeguridad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSgEmpleado = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSgSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSgEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSgGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSgConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSgClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSgUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSgEmpleado);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSgClave);
            this.panel1.Controls.Add(this.txtSgUsuario);
            this.panel1.Location = new System.Drawing.Point(46, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 236);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Empleado:";
            // 
            // cbSgEmpleado
            // 
            this.cbSgEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.cbSgEmpleado.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSgEmpleado.FormattingEnabled = true;
            this.cbSgEmpleado.Location = new System.Drawing.Point(102, 62);
            this.cbSgEmpleado.Name = "cbSgEmpleado";
            this.cbSgEmpleado.Size = new System.Drawing.Size(397, 21);
            this.cbSgEmpleado.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.btnSgSalir);
            this.panel2.Controls.Add(this.btnSgEliminar);
            this.panel2.Controls.Add(this.btnSgGuardar);
            this.panel2.Controls.Add(this.btnSgConsultar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 234);
            this.panel2.TabIndex = 7;
            // 
            // btnSgSalir
            // 
            this.btnSgSalir.AutoSize = true;
            this.btnSgSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSgSalir.Depth = 0;
            this.btnSgSalir.FlatAppearance.BorderSize = 0;
            this.btnSgSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSgSalir.Icon = null;
            this.btnSgSalir.Location = new System.Drawing.Point(55, 173);
            this.btnSgSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSgSalir.Name = "btnSgSalir";
            this.btnSgSalir.Primary = true;
            this.btnSgSalir.Size = new System.Drawing.Size(72, 36);
            this.btnSgSalir.TabIndex = 3;
            this.btnSgSalir.Text = "S A L I R";
            this.btnSgSalir.UseVisualStyleBackColor = true;
            this.btnSgSalir.Click += new System.EventHandler(this.BtnSgSalir_Click);
            // 
            // btnSgEliminar
            // 
            this.btnSgEliminar.AutoSize = true;
            this.btnSgEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSgEliminar.Depth = 0;
            this.btnSgEliminar.FlatAppearance.BorderSize = 0;
            this.btnSgEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSgEliminar.Icon = null;
            this.btnSgEliminar.Location = new System.Drawing.Point(38, 124);
            this.btnSgEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSgEliminar.Name = "btnSgEliminar";
            this.btnSgEliminar.Primary = true;
            this.btnSgEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnSgEliminar.TabIndex = 2;
            this.btnSgEliminar.Text = "E L I M I N A R";
            this.btnSgEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSgGuardar
            // 
            this.btnSgGuardar.AutoSize = true;
            this.btnSgGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSgGuardar.Depth = 0;
            this.btnSgGuardar.FlatAppearance.BorderSize = 0;
            this.btnSgGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSgGuardar.Icon = null;
            this.btnSgGuardar.Location = new System.Drawing.Point(39, 75);
            this.btnSgGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSgGuardar.Name = "btnSgGuardar";
            this.btnSgGuardar.Primary = true;
            this.btnSgGuardar.Size = new System.Drawing.Size(104, 36);
            this.btnSgGuardar.TabIndex = 1;
            this.btnSgGuardar.Text = "G U A R D A R";
            this.btnSgGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSgConsultar
            // 
            this.btnSgConsultar.AutoSize = true;
            this.btnSgConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSgConsultar.Depth = 0;
            this.btnSgConsultar.FlatAppearance.BorderSize = 0;
            this.btnSgConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSgConsultar.Icon = null;
            this.btnSgConsultar.Location = new System.Drawing.Point(28, 24);
            this.btnSgConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSgConsultar.Name = "btnSgConsultar";
            this.btnSgConsultar.Primary = true;
            this.btnSgConsultar.Size = new System.Drawing.Size(127, 36);
            this.btnSgConsultar.TabIndex = 0;
            this.btnSgConsultar.Text = "C O N S U L T A R";
            this.btnSgConsultar.UseVisualStyleBackColor = true;
            // 
            // txtSgClave
            // 
            this.txtSgClave.Depth = 0;
            this.txtSgClave.Hint = "Contraseña";
            this.txtSgClave.Location = new System.Drawing.Point(18, 147);
            this.txtSgClave.MaxLength = 32767;
            this.txtSgClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSgClave.Name = "txtSgClave";
            this.txtSgClave.PasswordChar = '\0';
            this.txtSgClave.SelectedText = "";
            this.txtSgClave.SelectionLength = 0;
            this.txtSgClave.SelectionStart = 0;
            this.txtSgClave.Size = new System.Drawing.Size(481, 23);
            this.txtSgClave.TabIndex = 4;
            this.txtSgClave.TabStop = false;
            this.txtSgClave.UseSystemPasswordChar = false;
            // 
            // txtSgUsuario
            // 
            this.txtSgUsuario.Depth = 0;
            this.txtSgUsuario.Hint = "Usuario";
            this.txtSgUsuario.Location = new System.Drawing.Point(18, 103);
            this.txtSgUsuario.MaxLength = 32767;
            this.txtSgUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSgUsuario.Name = "txtSgUsuario";
            this.txtSgUsuario.PasswordChar = '\0';
            this.txtSgUsuario.SelectedText = "";
            this.txtSgUsuario.SelectionLength = 0;
            this.txtSgUsuario.SelectionStart = 0;
            this.txtSgUsuario.Size = new System.Drawing.Size(481, 23);
            this.txtSgUsuario.TabIndex = 2;
            this.txtSgUsuario.TabStop = false;
            this.txtSgUsuario.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(302, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "S E G U R I DA D";
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeguridad";
            this.Text = "frmSeguridad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSgSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnSgEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSgGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSgClave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSgUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSgEmpleado;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSgConsultar;
    }
}