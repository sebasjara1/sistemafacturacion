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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgFcBusqueda = new System.Windows.Forms.DataGridView();
            this.btnFcBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFcBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFcSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFcEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFcActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFcNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFcDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFcImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFcNroFactura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFcCliente = new System.Windows.Forms.ComboBox();
            this.cbFcEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFcTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbFcEstadoFactura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgFcDetallesFactura = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcBusqueda)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcDetallesFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgFcBusqueda);
            this.panel3.Controls.Add(this.btnFcBuscar);
            this.panel3.Controls.Add(this.txtFcBusqueda);
            this.panel3.Location = new System.Drawing.Point(24, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 171);
            this.panel3.TabIndex = 12;
            // 
            // dgFcBusqueda
            // 
            this.dgFcBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgFcBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFcBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgFcBusqueda.Location = new System.Drawing.Point(0, 51);
            this.dgFcBusqueda.Name = "dgFcBusqueda";
            this.dgFcBusqueda.Size = new System.Drawing.Size(777, 118);
            this.dgFcBusqueda.TabIndex = 11;
            // 
            // btnFcBuscar
            // 
            this.btnFcBuscar.AutoSize = true;
            this.btnFcBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFcBuscar.Depth = 0;
            this.btnFcBuscar.FlatAppearance.BorderSize = 0;
            this.btnFcBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnFcBuscar.Icon = null;
            this.btnFcBuscar.Location = new System.Drawing.Point(600, 9);
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
            this.txtFcBusqueda.Location = new System.Drawing.Point(45, 16);
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
            this.panel1.Controls.Add(this.dgFcDetallesFactura);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbFcEstadoFactura);
            this.panel1.Controls.Add(this.cbFcEmpleado);
            this.panel1.Controls.Add(this.cbFcCliente);
            this.panel1.Controls.Add(this.lblFcNroFactura);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtFcDescuento);
            this.panel1.Controls.Add(this.txtFcTotal);
            this.panel1.Controls.Add(this.txtFcImpuesto);
            this.panel1.Location = new System.Drawing.Point(51, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 269);
            this.panel1.TabIndex = 10;
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
            this.btnFcSalir.Location = new System.Drawing.Point(52, 181);
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
            this.btnFcEliminar.Location = new System.Drawing.Point(38, 132);
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
            this.btnFcActualizar.Location = new System.Drawing.Point(24, 83);
            this.btnFcActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFcActualizar.Name = "btnFcActualizar";
            this.btnFcActualizar.Primary = true;
            this.btnFcActualizar.Size = new System.Drawing.Size(134, 36);
            this.btnFcActualizar.TabIndex = 1;
            this.btnFcActualizar.Text = "A C T U A L I Z A R";
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
            this.btnFcNuevo.Location = new System.Drawing.Point(52, 34);
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
            this.txtFcDescuento.Location = new System.Drawing.Point(18, 102);
            this.txtFcDescuento.MaxLength = 32767;
            this.txtFcDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcDescuento.Name = "txtFcDescuento";
            this.txtFcDescuento.PasswordChar = '\0';
            this.txtFcDescuento.SelectedText = "";
            this.txtFcDescuento.SelectionLength = 0;
            this.txtFcDescuento.SelectionStart = 0;
            this.txtFcDescuento.Size = new System.Drawing.Size(230, 23);
            this.txtFcDescuento.TabIndex = 3;
            this.txtFcDescuento.TabStop = false;
            this.txtFcDescuento.UseSystemPasswordChar = false;
            // 
            // txtFcImpuesto
            // 
            this.txtFcImpuesto.Depth = 0;
            this.txtFcImpuesto.Hint = "Valor Impuesto";
            this.txtFcImpuesto.Location = new System.Drawing.Point(265, 102);
            this.txtFcImpuesto.MaxLength = 32767;
            this.txtFcImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcImpuesto.Name = "txtFcImpuesto";
            this.txtFcImpuesto.PasswordChar = '\0';
            this.txtFcImpuesto.SelectedText = "";
            this.txtFcImpuesto.SelectionLength = 0;
            this.txtFcImpuesto.SelectionStart = 0;
            this.txtFcImpuesto.Size = new System.Drawing.Size(234, 23);
            this.txtFcImpuesto.TabIndex = 2;
            this.txtFcImpuesto.TabStop = false;
            this.txtFcImpuesto.UseSystemPasswordChar = false;
            // 
            // lblFcNroFactura
            // 
            this.lblFcNroFactura.AutoSize = true;
            this.lblFcNroFactura.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFcNroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lblFcNroFactura.Location = new System.Drawing.Point(220, 12);
            this.lblFcNroFactura.Name = "lblFcNroFactura";
            this.lblFcNroFactura.Size = new System.Drawing.Size(0, 20);
            this.lblFcNroFactura.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nro Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente:";
            // 
            // cbFcCliente
            // 
            this.cbFcCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFcCliente.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFcCliente.FormattingEnabled = true;
            this.cbFcCliente.Location = new System.Drawing.Point(81, 39);
            this.cbFcCliente.Name = "cbFcCliente";
            this.cbFcCliente.Size = new System.Drawing.Size(418, 21);
            this.cbFcCliente.TabIndex = 19;
            // 
            // cbFcEmpleado
            // 
            this.cbFcEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFcEmpleado.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFcEmpleado.FormattingEnabled = true;
            this.cbFcEmpleado.Location = new System.Drawing.Point(100, 70);
            this.cbFcEmpleado.Name = "cbFcEmpleado";
            this.cbFcEmpleado.Size = new System.Drawing.Size(399, 21);
            this.cbFcEmpleado.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empleado:";
            // 
            // txtFcTotal
            // 
            this.txtFcTotal.Depth = 0;
            this.txtFcTotal.Hint = "Valor Total";
            this.txtFcTotal.Location = new System.Drawing.Point(18, 134);
            this.txtFcTotal.MaxLength = 32767;
            this.txtFcTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFcTotal.Name = "txtFcTotal";
            this.txtFcTotal.PasswordChar = '\0';
            this.txtFcTotal.SelectedText = "";
            this.txtFcTotal.SelectionLength = 0;
            this.txtFcTotal.SelectionStart = 0;
            this.txtFcTotal.Size = new System.Drawing.Size(200, 23);
            this.txtFcTotal.TabIndex = 2;
            this.txtFcTotal.TabStop = false;
            this.txtFcTotal.UseSystemPasswordChar = false;
            // 
            // cbFcEstadoFactura
            // 
            this.cbFcEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbFcEstadoFactura.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFcEstadoFactura.FormattingEnabled = true;
            this.cbFcEstadoFactura.Location = new System.Drawing.Point(341, 135);
            this.cbFcEstadoFactura.Name = "cbFcEstadoFactura";
            this.cbFcEstadoFactura.Size = new System.Drawing.Size(158, 21);
            this.cbFcEstadoFactura.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(221, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Estado Factura:";
            // 
            // dgFcDetallesFactura
            // 
            this.dgFcDetallesFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgFcDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFcDetallesFactura.Location = new System.Drawing.Point(18, 169);
            this.dgFcDetallesFactura.Name = "dgFcDetallesFactura";
            this.dgFcDetallesFactura.Size = new System.Drawing.Size(480, 83);
            this.dgFcDetallesFactura.TabIndex = 21;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(857, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcBusqueda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFcDetallesFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgFcBusqueda;
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
        private System.Windows.Forms.Label lblFcNroFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFcEmpleado;
        private System.Windows.Forms.ComboBox cbFcCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFcTotal;
        private System.Windows.Forms.DataGridView dgFcDetallesFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFcEstadoFactura;
    }
}