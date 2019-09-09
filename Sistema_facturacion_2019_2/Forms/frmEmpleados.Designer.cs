namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgEmEmpleado = new System.Windows.Forms.DataGridView();
            this.btnEmBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEmBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmDatosAdicionales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEmFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEmFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmRol = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEmEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEmGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEmNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEmEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmId = new System.Windows.Forms.Label();
            this.epMensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmEmpleado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgEmEmpleado);
            this.panel3.Controls.Add(this.btnEmBuscar);
            this.panel3.Controls.Add(this.txtEmBusqueda);
            this.panel3.Location = new System.Drawing.Point(12, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 162);
            this.panel3.TabIndex = 12;
            // 
            // dgEmEmpleado
            // 
            this.dgEmEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.dgEmEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEmEmpleado.Location = new System.Drawing.Point(0, 52);
            this.dgEmEmpleado.Name = "dgEmEmpleado";
            this.dgEmEmpleado.Size = new System.Drawing.Size(777, 108);
            this.dgEmEmpleado.TabIndex = 11;
            this.dgEmEmpleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgEmEmpleado_CellMouseClick);
            // 
            // btnEmBuscar
            // 
            this.btnEmBuscar.AutoSize = true;
            this.btnEmBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmBuscar.Depth = 0;
            this.btnEmBuscar.FlatAppearance.BorderSize = 0;
            this.btnEmBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEmBuscar.Icon = null;
            this.btnEmBuscar.Location = new System.Drawing.Point(605, 10);
            this.btnEmBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmBuscar.Name = "btnEmBuscar";
            this.btnEmBuscar.Primary = true;
            this.btnEmBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnEmBuscar.TabIndex = 9;
            this.btnEmBuscar.Text = "B U S C A R";
            this.btnEmBuscar.UseVisualStyleBackColor = true;
            this.btnEmBuscar.Click += new System.EventHandler(this.BtnEmBuscar_Click);
            // 
            // txtEmBusqueda
            // 
            this.txtEmBusqueda.Depth = 0;
            this.txtEmBusqueda.Hint = "Buscar Usuario";
            this.txtEmBusqueda.Location = new System.Drawing.Point(48, 17);
            this.txtEmBusqueda.MaxLength = 32767;
            this.txtEmBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmBusqueda.Name = "txtEmBusqueda";
            this.txtEmBusqueda.PasswordChar = '\0';
            this.txtEmBusqueda.SelectedText = "";
            this.txtEmBusqueda.SelectionLength = 0;
            this.txtEmBusqueda.SelectionStart = 0;
            this.txtEmBusqueda.Size = new System.Drawing.Size(481, 23);
            this.txtEmBusqueda.TabIndex = 10;
            this.txtEmBusqueda.TabStop = false;
            this.txtEmBusqueda.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "E M P L E A D O S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmDatosAdicionales);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpEmFechaRetiro);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpEmFechaIngreso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbEmRol);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtEmEmail);
            this.panel1.Controls.Add(this.txtEmTelefono);
            this.panel1.Controls.Add(this.txtEmDireccion);
            this.panel1.Controls.Add(this.txtEmDocumento);
            this.panel1.Controls.Add(this.txtEmNombre);
            this.panel1.Location = new System.Drawing.Point(50, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 289);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(14, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Datos Adicionales:";
            // 
            // txtEmDatosAdicionales
            // 
            this.txtEmDatosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.txtEmDatosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmDatosAdicionales.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmDatosAdicionales.Location = new System.Drawing.Point(17, 205);
            this.txtEmDatosAdicionales.Multiline = true;
            this.txtEmDatosAdicionales.Name = "txtEmDatosAdicionales";
            this.txtEmDatosAdicionales.Size = new System.Drawing.Size(481, 67);
            this.txtEmDatosAdicionales.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(14, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha de Retiro:";
            // 
            // dtpEmFechaRetiro
            // 
            this.dtpEmFechaRetiro.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpEmFechaRetiro.CustomFormat = "yyyy-MM-dd";
            this.dtpEmFechaRetiro.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmFechaRetiro.Location = new System.Drawing.Point(153, 146);
            this.dtpEmFechaRetiro.Name = "dtpEmFechaRetiro";
            this.dtpEmFechaRetiro.Size = new System.Drawing.Size(346, 22);
            this.dtpEmFechaRetiro.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(14, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha de Ingreso:";
            // 
            // dtpEmFechaIngreso
            // 
            this.dtpEmFechaIngreso.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpEmFechaIngreso.CustomFormat = "yyyy-MM-dd";
            this.dtpEmFechaIngreso.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmFechaIngreso.Location = new System.Drawing.Point(153, 114);
            this.dtpEmFechaIngreso.Name = "dtpEmFechaIngreso";
            this.dtpEmFechaIngreso.Size = new System.Drawing.Size(346, 22);
            this.dtpEmFechaIngreso.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(265, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rol:";
            // 
            // cbEmRol
            // 
            this.cbEmRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.cbEmRol.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmRol.FormattingEnabled = true;
            this.cbEmRol.Location = new System.Drawing.Point(307, 81);
            this.cbEmRol.Name = "cbEmRol";
            this.cbEmRol.Size = new System.Drawing.Size(191, 21);
            this.cbEmRol.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.btnEmSalir);
            this.panel2.Controls.Add(this.btnEmEliminar);
            this.panel2.Controls.Add(this.btnEmGuardar);
            this.panel2.Controls.Add(this.btnEmNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 287);
            this.panel2.TabIndex = 7;
            // 
            // btnEmSalir
            // 
            this.btnEmSalir.AutoSize = true;
            this.btnEmSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmSalir.Depth = 0;
            this.btnEmSalir.FlatAppearance.BorderSize = 0;
            this.btnEmSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEmSalir.Icon = null;
            this.btnEmSalir.Location = new System.Drawing.Point(56, 181);
            this.btnEmSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmSalir.Name = "btnEmSalir";
            this.btnEmSalir.Primary = true;
            this.btnEmSalir.Size = new System.Drawing.Size(72, 36);
            this.btnEmSalir.TabIndex = 4;
            this.btnEmSalir.Text = "S A L I R";
            this.btnEmSalir.UseVisualStyleBackColor = true;
            this.btnEmSalir.Click += new System.EventHandler(this.BtnUsSalir_Click);
            // 
            // btnEmEliminar
            // 
            this.btnEmEliminar.AutoSize = true;
            this.btnEmEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmEliminar.Depth = 0;
            this.btnEmEliminar.FlatAppearance.BorderSize = 0;
            this.btnEmEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEmEliminar.Icon = null;
            this.btnEmEliminar.Location = new System.Drawing.Point(39, 132);
            this.btnEmEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmEliminar.Name = "btnEmEliminar";
            this.btnEmEliminar.Primary = true;
            this.btnEmEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnEmEliminar.TabIndex = 2;
            this.btnEmEliminar.Text = "E L I M I N A R";
            this.btnEmEliminar.UseVisualStyleBackColor = true;
            this.btnEmEliminar.Click += new System.EventHandler(this.BtnEmEliminar_Click);
            // 
            // btnEmGuardar
            // 
            this.btnEmGuardar.AutoSize = true;
            this.btnEmGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmGuardar.Depth = 0;
            this.btnEmGuardar.FlatAppearance.BorderSize = 0;
            this.btnEmGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEmGuardar.Icon = null;
            this.btnEmGuardar.Location = new System.Drawing.Point(40, 83);
            this.btnEmGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmGuardar.Name = "btnEmGuardar";
            this.btnEmGuardar.Primary = true;
            this.btnEmGuardar.Size = new System.Drawing.Size(104, 36);
            this.btnEmGuardar.TabIndex = 1;
            this.btnEmGuardar.Text = "G U A R D A R";
            this.btnEmGuardar.UseVisualStyleBackColor = true;
            this.btnEmGuardar.Click += new System.EventHandler(this.BtnEmGuardar_Click);
            // 
            // btnEmNuevo
            // 
            this.btnEmNuevo.AutoSize = true;
            this.btnEmNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmNuevo.Depth = 0;
            this.btnEmNuevo.FlatAppearance.BorderSize = 0;
            this.btnEmNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEmNuevo.Icon = null;
            this.btnEmNuevo.Location = new System.Drawing.Point(53, 34);
            this.btnEmNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmNuevo.Name = "btnEmNuevo";
            this.btnEmNuevo.Primary = true;
            this.btnEmNuevo.Size = new System.Drawing.Size(79, 36);
            this.btnEmNuevo.TabIndex = 0;
            this.btnEmNuevo.Text = "N U E V O";
            this.btnEmNuevo.UseVisualStyleBackColor = true;
            this.btnEmNuevo.Click += new System.EventHandler(this.BtnEmNuevo_Click);
            // 
            // txtEmEmail
            // 
            this.txtEmEmail.Depth = 0;
            this.txtEmEmail.Hint = "Email";
            this.txtEmEmail.Location = new System.Drawing.Point(18, 78);
            this.txtEmEmail.MaxLength = 32767;
            this.txtEmEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmEmail.Name = "txtEmEmail";
            this.txtEmEmail.PasswordChar = '\0';
            this.txtEmEmail.SelectedText = "";
            this.txtEmEmail.SelectionLength = 0;
            this.txtEmEmail.SelectionStart = 0;
            this.txtEmEmail.Size = new System.Drawing.Size(234, 23);
            this.txtEmEmail.TabIndex = 6;
            this.txtEmEmail.TabStop = false;
            this.txtEmEmail.UseSystemPasswordChar = false;
            // 
            // txtEmTelefono
            // 
            this.txtEmTelefono.Depth = 0;
            this.txtEmTelefono.Hint = "Teléfono";
            this.txtEmTelefono.Location = new System.Drawing.Point(269, 47);
            this.txtEmTelefono.MaxLength = 32767;
            this.txtEmTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmTelefono.Name = "txtEmTelefono";
            this.txtEmTelefono.PasswordChar = '\0';
            this.txtEmTelefono.SelectedText = "";
            this.txtEmTelefono.SelectionLength = 0;
            this.txtEmTelefono.SelectionStart = 0;
            this.txtEmTelefono.Size = new System.Drawing.Size(229, 23);
            this.txtEmTelefono.TabIndex = 5;
            this.txtEmTelefono.TabStop = false;
            this.txtEmTelefono.UseSystemPasswordChar = false;
            // 
            // txtEmDireccion
            // 
            this.txtEmDireccion.Depth = 0;
            this.txtEmDireccion.Hint = "Dirección";
            this.txtEmDireccion.Location = new System.Drawing.Point(17, 47);
            this.txtEmDireccion.MaxLength = 32767;
            this.txtEmDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmDireccion.Name = "txtEmDireccion";
            this.txtEmDireccion.PasswordChar = '\0';
            this.txtEmDireccion.SelectedText = "";
            this.txtEmDireccion.SelectionLength = 0;
            this.txtEmDireccion.SelectionStart = 0;
            this.txtEmDireccion.Size = new System.Drawing.Size(235, 23);
            this.txtEmDireccion.TabIndex = 4;
            this.txtEmDireccion.TabStop = false;
            this.txtEmDireccion.UseSystemPasswordChar = false;
            // 
            // txtEmDocumento
            // 
            this.txtEmDocumento.Depth = 0;
            this.txtEmDocumento.Hint = "Documento";
            this.txtEmDocumento.Location = new System.Drawing.Point(17, 14);
            this.txtEmDocumento.MaxLength = 32767;
            this.txtEmDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmDocumento.Name = "txtEmDocumento";
            this.txtEmDocumento.PasswordChar = '\0';
            this.txtEmDocumento.SelectedText = "";
            this.txtEmDocumento.SelectionLength = 0;
            this.txtEmDocumento.SelectionStart = 0;
            this.txtEmDocumento.Size = new System.Drawing.Size(235, 23);
            this.txtEmDocumento.TabIndex = 3;
            this.txtEmDocumento.TabStop = false;
            this.txtEmDocumento.UseSystemPasswordChar = false;
            // 
            // txtEmNombre
            // 
            this.txtEmNombre.Depth = 0;
            this.txtEmNombre.Hint = "Nombre";
            this.txtEmNombre.Location = new System.Drawing.Point(269, 14);
            this.txtEmNombre.MaxLength = 32767;
            this.txtEmNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmNombre.Name = "txtEmNombre";
            this.txtEmNombre.PasswordChar = '\0';
            this.txtEmNombre.SelectedText = "";
            this.txtEmNombre.SelectionLength = 0;
            this.txtEmNombre.SelectionStart = 0;
            this.txtEmNombre.Size = new System.Drawing.Size(229, 23);
            this.txtEmNombre.TabIndex = 2;
            this.txtEmNombre.TabStop = false;
            this.txtEmNombre.UseSystemPasswordChar = false;
            // 
            // lblEmId
            // 
            this.lblEmId.AutoSize = true;
            this.lblEmId.Location = new System.Drawing.Point(50, 13);
            this.lblEmId.Name = "lblEmId";
            this.lblEmId.Size = new System.Drawing.Size(25, 13);
            this.lblEmId.TabIndex = 13;
            this.lblEmId.Text = "000";
            // 
            // epMensajeError
            // 
            this.epMensajeError.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(842, 538);
            this.Controls.Add(this.lblEmId);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmEmpleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgEmEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEmFechaRetiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEmFechaIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmDatosAdicionales;
        private System.Windows.Forms.Label lblEmId;
        private System.Windows.Forms.ErrorProvider epMensajeError;
    }
}