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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgUsBusqueda = new System.Windows.Forms.DataGridView();
            this.btnUsBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUsBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsDatosAdicionales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpUsFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpUsFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpUsFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUsEscolaridad = new System.Windows.Forms.ComboBox();
            this.rdbUsHombre = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbUsMujer = new MaterialSkin.Controls.MaterialRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUsEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUsActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUsNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUsEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsBusqueda)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgUsBusqueda);
            this.panel3.Controls.Add(this.btnUsBuscar);
            this.panel3.Controls.Add(this.txtUsBusqueda);
            this.panel3.Location = new System.Drawing.Point(19, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 162);
            this.panel3.TabIndex = 12;
            // 
            // dgUsBusqueda
            // 
            this.dgUsBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.dgUsBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgUsBusqueda.Location = new System.Drawing.Point(0, 52);
            this.dgUsBusqueda.Name = "dgUsBusqueda";
            this.dgUsBusqueda.Size = new System.Drawing.Size(777, 108);
            this.dgUsBusqueda.TabIndex = 11;
            // 
            // btnUsBuscar
            // 
            this.btnUsBuscar.AutoSize = true;
            this.btnUsBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsBuscar.Depth = 0;
            this.btnUsBuscar.FlatAppearance.BorderSize = 0;
            this.btnUsBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUsBuscar.Icon = null;
            this.btnUsBuscar.Location = new System.Drawing.Point(605, 10);
            this.btnUsBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsBuscar.Name = "btnUsBuscar";
            this.btnUsBuscar.Primary = true;
            this.btnUsBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnUsBuscar.TabIndex = 9;
            this.btnUsBuscar.Text = "B U S C A R";
            this.btnUsBuscar.UseVisualStyleBackColor = true;
            // 
            // txtUsBusqueda
            // 
            this.txtUsBusqueda.Depth = 0;
            this.txtUsBusqueda.Hint = "Buscar Usuario";
            this.txtUsBusqueda.Location = new System.Drawing.Point(48, 17);
            this.txtUsBusqueda.MaxLength = 32767;
            this.txtUsBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsBusqueda.Name = "txtUsBusqueda";
            this.txtUsBusqueda.PasswordChar = '\0';
            this.txtUsBusqueda.SelectedText = "";
            this.txtUsBusqueda.SelectionLength = 0;
            this.txtUsBusqueda.SelectionStart = 0;
            this.txtUsBusqueda.Size = new System.Drawing.Size(481, 23);
            this.txtUsBusqueda.TabIndex = 10;
            this.txtUsBusqueda.TabStop = false;
            this.txtUsBusqueda.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "U S U A R I O S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtUsDatosAdicionales);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpUsFechaRetiro);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpUsFechaIngreso);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbUsCargo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpUsFechaNacimiento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbUsEscolaridad);
            this.panel1.Controls.Add(this.rdbUsHombre);
            this.panel1.Controls.Add(this.rdbUsMujer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtUsEmail);
            this.panel1.Controls.Add(this.txtUsTelefono);
            this.panel1.Controls.Add(this.txtUsDireccion);
            this.panel1.Controls.Add(this.txtUsDocumento);
            this.panel1.Controls.Add(this.txtUsNombre);
            this.panel1.Location = new System.Drawing.Point(50, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 356);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(14, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Datos Adicionales:";
            // 
            // txtUsDatosAdicionales
            // 
            this.txtUsDatosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.txtUsDatosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsDatosAdicionales.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsDatosAdicionales.Location = new System.Drawing.Point(17, 289);
            this.txtUsDatosAdicionales.Multiline = true;
            this.txtUsDatosAdicionales.Name = "txtUsDatosAdicionales";
            this.txtUsDatosAdicionales.Size = new System.Drawing.Size(481, 45);
            this.txtUsDatosAdicionales.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(13, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha de Retiro:";
            // 
            // dtpUsFechaRetiro
            // 
            this.dtpUsFechaRetiro.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpUsFechaRetiro.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUsFechaRetiro.Location = new System.Drawing.Point(152, 241);
            this.dtpUsFechaRetiro.Name = "dtpUsFechaRetiro";
            this.dtpUsFechaRetiro.Size = new System.Drawing.Size(346, 22);
            this.dtpUsFechaRetiro.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(13, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha de Ingreso:";
            // 
            // dtpUsFechaIngreso
            // 
            this.dtpUsFechaIngreso.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpUsFechaIngreso.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUsFechaIngreso.Location = new System.Drawing.Point(152, 209);
            this.dtpUsFechaIngreso.Name = "dtpUsFechaIngreso";
            this.dtpUsFechaIngreso.Size = new System.Drawing.Size(346, 22);
            this.dtpUsFechaIngreso.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cargo:";
            // 
            // cbUsCargo
            // 
            this.cbUsCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.cbUsCargo.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsCargo.FormattingEnabled = true;
            this.cbUsCargo.Location = new System.Drawing.Point(75, 179);
            this.cbUsCargo.Name = "cbUsCargo";
            this.cbUsCargo.Size = new System.Drawing.Size(424, 21);
            this.cbUsCargo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // dtpUsFechaNacimiento
            // 
            this.dtpUsFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpUsFechaNacimiento.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUsFechaNacimiento.Location = new System.Drawing.Point(180, 147);
            this.dtpUsFechaNacimiento.Name = "dtpUsFechaNacimiento";
            this.dtpUsFechaNacimiento.Size = new System.Drawing.Size(318, 22);
            this.dtpUsFechaNacimiento.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Escolaridad:";
            // 
            // cbUsEscolaridad
            // 
            this.cbUsEscolaridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.cbUsEscolaridad.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsEscolaridad.FormattingEnabled = true;
            this.cbUsEscolaridad.Location = new System.Drawing.Point(115, 113);
            this.cbUsEscolaridad.Name = "cbUsEscolaridad";
            this.cbUsEscolaridad.Size = new System.Drawing.Size(384, 21);
            this.cbUsEscolaridad.TabIndex = 17;
            // 
            // rdbUsHombre
            // 
            this.rdbUsHombre.AutoSize = true;
            this.rdbUsHombre.Depth = 0;
            this.rdbUsHombre.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbUsHombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.rdbUsHombre.Location = new System.Drawing.Point(172, 43);
            this.rdbUsHombre.Margin = new System.Windows.Forms.Padding(0);
            this.rdbUsHombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbUsHombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbUsHombre.Name = "rdbUsHombre";
            this.rdbUsHombre.Ripple = true;
            this.rdbUsHombre.Size = new System.Drawing.Size(78, 30);
            this.rdbUsHombre.TabIndex = 16;
            this.rdbUsHombre.TabStop = true;
            this.rdbUsHombre.Text = "Hombre";
            this.rdbUsHombre.UseVisualStyleBackColor = true;
            // 
            // rdbUsMujer
            // 
            this.rdbUsMujer.AutoSize = true;
            this.rdbUsMujer.Depth = 0;
            this.rdbUsMujer.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbUsMujer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.rdbUsMujer.Location = new System.Drawing.Point(87, 43);
            this.rdbUsMujer.Margin = new System.Windows.Forms.Padding(0);
            this.rdbUsMujer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbUsMujer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbUsMujer.Name = "rdbUsMujer";
            this.rdbUsMujer.Ripple = true;
            this.rdbUsMujer.Size = new System.Drawing.Size(64, 30);
            this.rdbUsMujer.TabIndex = 15;
            this.rdbUsMujer.TabStop = true;
            this.rdbUsMujer.Text = "Mujer";
            this.rdbUsMujer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sexo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.btnUsSalir);
            this.panel2.Controls.Add(this.btnUsEliminar);
            this.panel2.Controls.Add(this.btnUsActualizar);
            this.panel2.Controls.Add(this.btnUsNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 354);
            this.panel2.TabIndex = 7;
            // 
            // btnUsSalir
            // 
            this.btnUsSalir.AutoSize = true;
            this.btnUsSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsSalir.Depth = 0;
            this.btnUsSalir.FlatAppearance.BorderSize = 0;
            this.btnUsSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUsSalir.Icon = null;
            this.btnUsSalir.Location = new System.Drawing.Point(53, 225);
            this.btnUsSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsSalir.Name = "btnUsSalir";
            this.btnUsSalir.Primary = true;
            this.btnUsSalir.Size = new System.Drawing.Size(72, 36);
            this.btnUsSalir.TabIndex = 4;
            this.btnUsSalir.Text = "S A L I R";
            this.btnUsSalir.UseVisualStyleBackColor = true;
            this.btnUsSalir.Click += new System.EventHandler(this.BtnUsSalir_Click);
            // 
            // btnUsEliminar
            // 
            this.btnUsEliminar.AutoSize = true;
            this.btnUsEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsEliminar.Depth = 0;
            this.btnUsEliminar.FlatAppearance.BorderSize = 0;
            this.btnUsEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUsEliminar.Icon = null;
            this.btnUsEliminar.Location = new System.Drawing.Point(39, 176);
            this.btnUsEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsEliminar.Name = "btnUsEliminar";
            this.btnUsEliminar.Primary = true;
            this.btnUsEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnUsEliminar.TabIndex = 2;
            this.btnUsEliminar.Text = "E L I M I N A R";
            this.btnUsEliminar.UseVisualStyleBackColor = true;
            // 
            // btnUsActualizar
            // 
            this.btnUsActualizar.AutoSize = true;
            this.btnUsActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsActualizar.Depth = 0;
            this.btnUsActualizar.FlatAppearance.BorderSize = 0;
            this.btnUsActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUsActualizar.Icon = null;
            this.btnUsActualizar.Location = new System.Drawing.Point(25, 127);
            this.btnUsActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsActualizar.Name = "btnUsActualizar";
            this.btnUsActualizar.Primary = true;
            this.btnUsActualizar.Size = new System.Drawing.Size(134, 36);
            this.btnUsActualizar.TabIndex = 1;
            this.btnUsActualizar.Text = "A C T U A L I Z A R";
            this.btnUsActualizar.UseVisualStyleBackColor = true;
            // 
            // btnUsNuevo
            // 
            this.btnUsNuevo.AutoSize = true;
            this.btnUsNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsNuevo.Depth = 0;
            this.btnUsNuevo.FlatAppearance.BorderSize = 0;
            this.btnUsNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUsNuevo.Icon = null;
            this.btnUsNuevo.Location = new System.Drawing.Point(53, 78);
            this.btnUsNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsNuevo.Name = "btnUsNuevo";
            this.btnUsNuevo.Primary = true;
            this.btnUsNuevo.Size = new System.Drawing.Size(79, 36);
            this.btnUsNuevo.TabIndex = 0;
            this.btnUsNuevo.Text = "N U E V O";
            this.btnUsNuevo.UseVisualStyleBackColor = true;
            // 
            // txtUsEmail
            // 
            this.txtUsEmail.Depth = 0;
            this.txtUsEmail.Hint = "Email";
            this.txtUsEmail.Location = new System.Drawing.Point(269, 47);
            this.txtUsEmail.MaxLength = 32767;
            this.txtUsEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsEmail.Name = "txtUsEmail";
            this.txtUsEmail.PasswordChar = '\0';
            this.txtUsEmail.SelectedText = "";
            this.txtUsEmail.SelectionLength = 0;
            this.txtUsEmail.SelectionStart = 0;
            this.txtUsEmail.Size = new System.Drawing.Size(229, 23);
            this.txtUsEmail.TabIndex = 6;
            this.txtUsEmail.TabStop = false;
            this.txtUsEmail.UseSystemPasswordChar = false;
            // 
            // txtUsTelefono
            // 
            this.txtUsTelefono.Depth = 0;
            this.txtUsTelefono.Hint = "Teléfono";
            this.txtUsTelefono.Location = new System.Drawing.Point(269, 78);
            this.txtUsTelefono.MaxLength = 32767;
            this.txtUsTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsTelefono.Name = "txtUsTelefono";
            this.txtUsTelefono.PasswordChar = '\0';
            this.txtUsTelefono.SelectedText = "";
            this.txtUsTelefono.SelectionLength = 0;
            this.txtUsTelefono.SelectionStart = 0;
            this.txtUsTelefono.Size = new System.Drawing.Size(229, 23);
            this.txtUsTelefono.TabIndex = 5;
            this.txtUsTelefono.TabStop = false;
            this.txtUsTelefono.UseSystemPasswordChar = false;
            // 
            // txtUsDireccion
            // 
            this.txtUsDireccion.Depth = 0;
            this.txtUsDireccion.Hint = "Dirección";
            this.txtUsDireccion.Location = new System.Drawing.Point(17, 78);
            this.txtUsDireccion.MaxLength = 32767;
            this.txtUsDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsDireccion.Name = "txtUsDireccion";
            this.txtUsDireccion.PasswordChar = '\0';
            this.txtUsDireccion.SelectedText = "";
            this.txtUsDireccion.SelectionLength = 0;
            this.txtUsDireccion.SelectionStart = 0;
            this.txtUsDireccion.Size = new System.Drawing.Size(235, 23);
            this.txtUsDireccion.TabIndex = 4;
            this.txtUsDireccion.TabStop = false;
            this.txtUsDireccion.UseSystemPasswordChar = false;
            // 
            // txtUsDocumento
            // 
            this.txtUsDocumento.Depth = 0;
            this.txtUsDocumento.Hint = "Documento";
            this.txtUsDocumento.Location = new System.Drawing.Point(17, 14);
            this.txtUsDocumento.MaxLength = 32767;
            this.txtUsDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsDocumento.Name = "txtUsDocumento";
            this.txtUsDocumento.PasswordChar = '\0';
            this.txtUsDocumento.SelectedText = "";
            this.txtUsDocumento.SelectionLength = 0;
            this.txtUsDocumento.SelectionStart = 0;
            this.txtUsDocumento.Size = new System.Drawing.Size(235, 23);
            this.txtUsDocumento.TabIndex = 3;
            this.txtUsDocumento.TabStop = false;
            this.txtUsDocumento.UseSystemPasswordChar = false;
            // 
            // txtUsNombre
            // 
            this.txtUsNombre.Depth = 0;
            this.txtUsNombre.Hint = "Nombre";
            this.txtUsNombre.Location = new System.Drawing.Point(269, 14);
            this.txtUsNombre.MaxLength = 32767;
            this.txtUsNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsNombre.Name = "txtUsNombre";
            this.txtUsNombre.PasswordChar = '\0';
            this.txtUsNombre.SelectedText = "";
            this.txtUsNombre.SelectionLength = 0;
            this.txtUsNombre.SelectionStart = 0;
            this.txtUsNombre.Size = new System.Drawing.Size(229, 23);
            this.txtUsNombre.TabIndex = 2;
            this.txtUsNombre.TabStop = false;
            this.txtUsNombre.UseSystemPasswordChar = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(842, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleado";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsBusqueda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgUsBusqueda;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsNombre;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRadioButton rdbUsHombre;
        private MaterialSkin.Controls.MaterialRadioButton rdbUsMujer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpUsFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUsEscolaridad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpUsFechaRetiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpUsFechaIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUsCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsDatosAdicionales;
    }
}