namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmFacturas
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
            this.dgFcFactura = new System.Windows.Forms.DataGridView();
            this.btnFcBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFcBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgFcDetallesFactura = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFcEstadoFactura = new System.Windows.Forms.ComboBox();
            this.cbFcEmpleado = new System.Windows.Forms.ComboBox();
            this.cbFcCliente = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFcSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFcEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFcActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFcNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFcDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFcTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFcImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFcId = new System.Windows.Forms.Label();
            this.epFcMensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFcFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDfId = new System.Windows.Forms.Label();
            this.cbFdProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDfCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDfPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDgAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcFactura)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcDetallesFactura)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFcMensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgFcFactura);
            this.panel3.Controls.Add(this.btnFcBuscar);
            this.panel3.Controls.Add(this.txtFcBusqueda);
            this.panel3.Location = new System.Drawing.Point(24, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 133);
            this.panel3.TabIndex = 12;
            // 
            // dgFcFactura
            // 
            this.dgFcFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgFcFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFcFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgFcFactura.Location = new System.Drawing.Point(0, 45);
            this.dgFcFactura.Name = "dgFcFactura";
            this.dgFcFactura.Size = new System.Drawing.Size(777, 86);
            this.dgFcFactura.TabIndex = 11;
            // 
            // btnFcBuscar
            // 
            this.btnFcBuscar.AutoSize = true;
            this.btnFcBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFcBuscar.Depth = 0;
            this.btnFcBuscar.FlatAppearance.BorderSize = 0;
            this.btnFcBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFcBuscar.Icon = null;
            this.btnFcBuscar.Location = new System.Drawing.Point(600, 5);
            this.btnFcBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcBuscar.Name = "btnFcBuscar";
            this.btnFcBuscar.Primary = true;
            this.btnFcBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnFcBuscar.TabIndex = 9;
            this.btnFcBuscar.Text = "B U S C A R";
            this.btnFcBuscar.UseVisualStyleBackColor = true;
            // 
            // txtFcBusqueda
            // 
            this.txtFcBusqueda.Depth = 0;
            this.txtFcBusqueda.Hint = "Buscar Factura";
            this.txtFcBusqueda.Location = new System.Drawing.Point(45, 9);
            this.txtFcBusqueda.MaxLength = 32767;
            this.txtFcBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcBusqueda.Name = "txtFcBusqueda";
            this.txtFcBusqueda.PasswordChar = '\0';
            this.txtFcBusqueda.SelectedText = "";
            this.txtFcBusqueda.SelectionLength = 0;
            this.txtFcBusqueda.SelectionStart = 0;
            this.txtFcBusqueda.Size = new System.Drawing.Size(481, 23);
            this.txtFcBusqueda.TabIndex = 10;
            this.txtFcBusqueda.TabStop = false;
            this.txtFcBusqueda.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(323, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "F A C T U R A S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDgAgregar);
            this.panel1.Controls.Add(this.txtDfPrecio);
            this.panel1.Controls.Add(this.txtDfCantidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFcFecha);
            this.panel1.Controls.Add(this.dgFcDetallesFactura);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbFcEstadoFactura);
            this.panel1.Controls.Add(this.cbFdProducto);
            this.panel1.Controls.Add(this.cbFcEmpleado);
            this.panel1.Controls.Add(this.cbFcCliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtFcDescuento);
            this.panel1.Controls.Add(this.txtFcTotal);
            this.panel1.Controls.Add(this.txtFcImpuesto);
            this.panel1.Location = new System.Drawing.Point(51, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 311);
            this.panel1.TabIndex = 10;
            // 
            // dgFcDetallesFactura
            // 
            this.dgFcDetallesFactura.AllowUserToAddRows = false;
            this.dgFcDetallesFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFcDetallesFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgFcDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFcDetallesFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgFcDetallesFactura.Location = new System.Drawing.Point(18, 182);
            this.dgFcDetallesFactura.Name = "dgFcDetallesFactura";
            this.dgFcDetallesFactura.Size = new System.Drawing.Size(496, 78);
            this.dgFcDetallesFactura.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(245, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Estado Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(245, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente:";
            // 
            // cbFcEstadoFactura
            // 
            this.cbFcEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFcEstadoFactura.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFcEstadoFactura.FormattingEnabled = true;
            this.cbFcEstadoFactura.Location = new System.Drawing.Point(371, 70);
            this.cbFcEstadoFactura.Name = "cbFcEstadoFactura";
            this.cbFcEstadoFactura.Size = new System.Drawing.Size(143, 21);
            this.cbFcEstadoFactura.TabIndex = 19;
            // 
            // cbFcEmpleado
            // 
            this.cbFcEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFcEmpleado.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFcEmpleado.FormattingEnabled = true;
            this.cbFcEmpleado.Location = new System.Drawing.Point(100, 39);
            this.cbFcEmpleado.Name = "cbFcEmpleado";
            this.cbFcEmpleado.Size = new System.Drawing.Size(136, 21);
            this.cbFcEmpleado.TabIndex = 19;
            // 
            // cbFcCliente
            // 
            this.cbFcCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFcCliente.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFcCliente.FormattingEnabled = true;
            this.cbFcCliente.Location = new System.Drawing.Point(312, 10);
            this.cbFcCliente.Name = "cbFcCliente";
            this.cbFcCliente.Size = new System.Drawing.Size(202, 21);
            this.cbFcCliente.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel2.Controls.Add(this.btnFcSalir);
            this.panel2.Controls.Add(this.btnFcEliminar);
            this.panel2.Controls.Add(this.btnFcActualizar);
            this.panel2.Controls.Add(this.btnFcNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 309);
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
            this.btnFcSalir.Location = new System.Drawing.Point(52, 204);
            this.btnFcSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcSalir.Name = "btnFcSalir";
            this.btnFcSalir.Primary = true;
            this.btnFcSalir.Size = new System.Drawing.Size(72, 36);
            this.btnFcSalir.TabIndex = 4;
            this.btnFcSalir.Text = "S A L I R";
            this.btnFcSalir.UseVisualStyleBackColor = true;
            this.btnFcSalir.Click += new System.EventHandler(this.BtnFcSalir_Click);
            // 
            // btnFcEliminar
            // 
            this.btnFcEliminar.AutoSize = true;
            this.btnFcEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFcEliminar.Depth = 0;
            this.btnFcEliminar.FlatAppearance.BorderSize = 0;
            this.btnFcEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFcEliminar.Icon = null;
            this.btnFcEliminar.Location = new System.Drawing.Point(38, 155);
            this.btnFcEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcEliminar.Name = "btnFcEliminar";
            this.btnFcEliminar.Primary = true;
            this.btnFcEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnFcEliminar.TabIndex = 2;
            this.btnFcEliminar.Text = "E L I M I N A R";
            this.btnFcEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFcActualizar
            // 
            this.btnFcActualizar.AutoSize = true;
            this.btnFcActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFcActualizar.Depth = 0;
            this.btnFcActualizar.FlatAppearance.BorderSize = 0;
            this.btnFcActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFcActualizar.Icon = null;
            this.btnFcActualizar.Location = new System.Drawing.Point(38, 106);
            this.btnFcActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcActualizar.Name = "btnFcActualizar";
            this.btnFcActualizar.Primary = true;
            this.btnFcActualizar.Size = new System.Drawing.Size(104, 36);
            this.btnFcActualizar.TabIndex = 1;
            this.btnFcActualizar.Text = "G U A R D A R";
            this.btnFcActualizar.UseVisualStyleBackColor = true;
            // 
            // btnFcNuevo
            // 
            this.btnFcNuevo.AutoSize = true;
            this.btnFcNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFcNuevo.Depth = 0;
            this.btnFcNuevo.FlatAppearance.BorderSize = 0;
            this.btnFcNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFcNuevo.Icon = null;
            this.btnFcNuevo.Location = new System.Drawing.Point(52, 57);
            this.btnFcNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcNuevo.Name = "btnFcNuevo";
            this.btnFcNuevo.Primary = true;
            this.btnFcNuevo.Size = new System.Drawing.Size(79, 36);
            this.btnFcNuevo.TabIndex = 0;
            this.btnFcNuevo.Text = "N U E V O";
            this.btnFcNuevo.UseVisualStyleBackColor = true;
            // 
            // txtFcDescuento
            // 
            this.txtFcDescuento.Depth = 0;
            this.txtFcDescuento.Hint = "% Descuento";
            this.txtFcDescuento.Location = new System.Drawing.Point(249, 38);
            this.txtFcDescuento.MaxLength = 32767;
            this.txtFcDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcDescuento.Name = "txtFcDescuento";
            this.txtFcDescuento.PasswordChar = '\0';
            this.txtFcDescuento.SelectedText = "";
            this.txtFcDescuento.SelectionLength = 0;
            this.txtFcDescuento.SelectionStart = 0;
            this.txtFcDescuento.Size = new System.Drawing.Size(265, 23);
            this.txtFcDescuento.TabIndex = 3;
            this.txtFcDescuento.TabStop = false;
            this.txtFcDescuento.UseSystemPasswordChar = false;
            // 
            // txtFcTotal
            // 
            this.txtFcTotal.Depth = 0;
            this.txtFcTotal.Hint = "Valor Total";
            this.txtFcTotal.Location = new System.Drawing.Point(19, 271);
            this.txtFcTotal.MaxLength = 32767;
            this.txtFcTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcTotal.Name = "txtFcTotal";
            this.txtFcTotal.PasswordChar = '\0';
            this.txtFcTotal.SelectedText = "";
            this.txtFcTotal.SelectionLength = 0;
            this.txtFcTotal.SelectionStart = 0;
            this.txtFcTotal.Size = new System.Drawing.Size(218, 23);
            this.txtFcTotal.TabIndex = 2;
            this.txtFcTotal.TabStop = false;
            this.txtFcTotal.UseSystemPasswordChar = false;
            // 
            // txtFcImpuesto
            // 
            this.txtFcImpuesto.Depth = 0;
            this.txtFcImpuesto.Hint = "Valor Impuesto";
            this.txtFcImpuesto.Location = new System.Drawing.Point(18, 67);
            this.txtFcImpuesto.MaxLength = 32767;
            this.txtFcImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcImpuesto.Name = "txtFcImpuesto";
            this.txtFcImpuesto.PasswordChar = '\0';
            this.txtFcImpuesto.SelectedText = "";
            this.txtFcImpuesto.SelectionLength = 0;
            this.txtFcImpuesto.SelectionStart = 0;
            this.txtFcImpuesto.Size = new System.Drawing.Size(218, 23);
            this.txtFcImpuesto.TabIndex = 2;
            this.txtFcImpuesto.TabStop = false;
            this.txtFcImpuesto.UseSystemPasswordChar = false;
            // 
            // lblFcId
            // 
            this.lblFcId.AutoSize = true;
            this.lblFcId.Location = new System.Drawing.Point(49, 36);
            this.lblFcId.Name = "lblFcId";
            this.lblFcId.Size = new System.Drawing.Size(25, 13);
            this.lblFcId.TabIndex = 13;
            this.lblFcId.Text = "000";
            // 
            // epFcMensajeError
            // 
            this.epFcMensajeError.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(14, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha:";
            // 
            // dtpFcFecha
            // 
            this.dtpFcFecha.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtpFcFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFcFecha.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFcFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFcFecha.Location = new System.Drawing.Point(74, 10);
            this.dtpFcFecha.Name = "dtpFcFecha";
            this.dtpFcFecha.Size = new System.Drawing.Size(162, 22);
            this.dtpFcFecha.TabIndex = 25;
            // 
            // lblDfId
            // 
            this.lblDfId.AutoSize = true;
            this.lblDfId.Location = new System.Drawing.Point(13, 282);
            this.lblDfId.Name = "lblDfId";
            this.lblDfId.Size = new System.Drawing.Size(25, 13);
            this.lblDfId.TabIndex = 14;
            this.lblDfId.Text = "000";
            // 
            // cbFdProducto
            // 
            this.cbFdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFdProducto.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFdProducto.FormattingEnabled = true;
            this.cbFdProducto.Location = new System.Drawing.Point(97, 122);
            this.cbFdProducto.Name = "cbFdProducto";
            this.cbFdProducto.Size = new System.Drawing.Size(268, 21);
            this.cbFdProducto.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Producto:";
            // 
            // txtDfCantidad
            // 
            this.txtDfCantidad.Depth = 0;
            this.txtDfCantidad.Hint = "Cantidad";
            this.txtDfCantidad.Location = new System.Drawing.Point(18, 150);
            this.txtDfCantidad.MaxLength = 32767;
            this.txtDfCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDfCantidad.Name = "txtDfCantidad";
            this.txtDfCantidad.PasswordChar = '\0';
            this.txtDfCantidad.SelectedText = "";
            this.txtDfCantidad.SelectionLength = 0;
            this.txtDfCantidad.SelectionStart = 0;
            this.txtDfCantidad.Size = new System.Drawing.Size(244, 23);
            this.txtDfCantidad.TabIndex = 27;
            this.txtDfCantidad.TabStop = false;
            this.txtDfCantidad.UseSystemPasswordChar = false;
            // 
            // txtDfPrecio
            // 
            this.txtDfPrecio.Depth = 0;
            this.txtDfPrecio.Enabled = false;
            this.txtDfPrecio.Hint = "Precio";
            this.txtDfPrecio.Location = new System.Drawing.Point(274, 149);
            this.txtDfPrecio.MaxLength = 32767;
            this.txtDfPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDfPrecio.Name = "txtDfPrecio";
            this.txtDfPrecio.PasswordChar = '\0';
            this.txtDfPrecio.SelectedText = "";
            this.txtDfPrecio.SelectionLength = 0;
            this.txtDfPrecio.SelectionStart = 0;
            this.txtDfPrecio.Size = new System.Drawing.Size(240, 23);
            this.txtDfPrecio.TabIndex = 28;
            this.txtDfPrecio.TabStop = false;
            this.txtDfPrecio.UseSystemPasswordChar = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // btnDgAgregar
            // 
            this.btnDgAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDgAgregar.Depth = 0;
            this.btnDgAgregar.Icon = null;
            this.btnDgAgregar.Location = new System.Drawing.Point(383, 119);
            this.btnDgAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDgAgregar.Name = "btnDgAgregar";
            this.btnDgAgregar.Primary = true;
            this.btnDgAgregar.Size = new System.Drawing.Size(128, 26);
            this.btnDgAgregar.TabIndex = 29;
            this.btnDgAgregar.Text = "A G R E G A R";
            this.btnDgAgregar.UseVisualStyleBackColor = true;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(857, 562);
            this.Controls.Add(this.lblDfId);
            this.Controls.Add(this.lblFcId);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcDetallesFactura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFcMensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgFcFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnFcBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFcBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnFcSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnFcEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnFcActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnFcNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFcDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFcImpuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFcEmpleado;
        private System.Windows.Forms.ComboBox cbFcCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFcTotal;
        private System.Windows.Forms.DataGridView dgFcDetallesFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFcEstadoFactura;
        private System.Windows.Forms.Label lblFcId;
        private System.Windows.Forms.ErrorProvider epFcMensajeError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFcFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDfPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDfCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFdProducto;
        private System.Windows.Forms.Label lblDfId;
        private MaterialSkin.Controls.MaterialRaisedButton btnDgAgregar;
    }
}