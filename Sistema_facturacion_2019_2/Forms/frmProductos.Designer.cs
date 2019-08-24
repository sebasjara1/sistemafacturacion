namespace Sistema_facturacion_2019_2
{
    partial class frmProductos
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
            this.dgPdBusqueda = new System.Windows.Forms.DataGridView();
            this.btnPdBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPdBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPdCodProducto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPdDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPdCategoria = new System.Windows.Forms.ComboBox();
            this.txtPdCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPdSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPdEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPdActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPdNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtImagenProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPdPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPdPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPdNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pbPdImagen = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPdBusqueda)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgPdBusqueda);
            this.panel3.Controls.Add(this.btnPdBuscar);
            this.panel3.Controls.Add(this.txtPdBusqueda);
            this.panel3.Location = new System.Drawing.Point(19, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 172);
            this.panel3.TabIndex = 12;
            // 
            // dgPdBusqueda
            // 
            this.dgPdBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgPdBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPdBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgPdBusqueda.Location = new System.Drawing.Point(0, 54);
            this.dgPdBusqueda.Name = "dgPdBusqueda";
            this.dgPdBusqueda.Size = new System.Drawing.Size(775, 116);
            this.dgPdBusqueda.TabIndex = 11;
            // 
            // btnPdBuscar
            // 
            this.btnPdBuscar.AutoSize = true;
            this.btnPdBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdBuscar.Depth = 0;
            this.btnPdBuscar.FlatAppearance.BorderSize = 0;
            this.btnPdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnPdBuscar.Icon = null;
            this.btnPdBuscar.Location = new System.Drawing.Point(600, 13);
            this.btnPdBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdBuscar.Name = "btnPdBuscar";
            this.btnPdBuscar.Primary = true;
            this.btnPdBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnPdBuscar.TabIndex = 9;
            this.btnPdBuscar.Text = "B U S C A R";
            this.btnPdBuscar.UseVisualStyleBackColor = true;
            // 
            // txtPdBusqueda
            // 
            this.txtPdBusqueda.Depth = 0;
            this.txtPdBusqueda.Hint = "Buscar Producto";
            this.txtPdBusqueda.Location = new System.Drawing.Point(45, 21);
            this.txtPdBusqueda.MaxLength = 32767;
            this.txtPdBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPdBusqueda.Name = "txtPdBusqueda";
            this.txtPdBusqueda.PasswordChar = '\0';
            this.txtPdBusqueda.SelectedText = "";
            this.txtPdBusqueda.SelectionLength = 0;
            this.txtPdBusqueda.SelectionStart = 0;
            this.txtPdBusqueda.Size = new System.Drawing.Size(481, 23);
            this.txtPdBusqueda.TabIndex = 10;
            this.txtPdBusqueda.TabStop = false;
            this.txtPdBusqueda.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(214, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPdCodProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPdDetalle);
            this.panel1.Controls.Add(this.pbPdImagen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbPdCategoria);
            this.panel1.Controls.Add(this.txtPdCantidadStock);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtImagenProducto);
            this.panel1.Controls.Add(this.txtPdPrecioVenta);
            this.panel1.Controls.Add(this.txtPdPrecioCompra);
            this.panel1.Controls.Add(this.txtPdNombre);
            this.panel1.Location = new System.Drawing.Point(19, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 326);
            this.panel1.TabIndex = 10;
            // 
            // lblPdCodProducto
            // 
            this.lblPdCodProducto.AutoSize = true;
            this.lblPdCodProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdCodProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lblPdCodProducto.Location = new System.Drawing.Point(217, 18);
            this.lblPdCodProducto.Name = "lblPdCodProducto";
            this.lblPdCodProducto.Size = new System.Drawing.Size(0, 20);
            this.lblPdCodProducto.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Código Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(13, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Detalles:";
            // 
            // txtPdDetalle
            // 
            this.txtPdDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.txtPdDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPdDetalle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPdDetalle.Location = new System.Drawing.Point(16, 230);
            this.txtPdDetalle.Multiline = true;
            this.txtPdDetalle.Name = "txtPdDetalle";
            this.txtPdDetalle.Size = new System.Drawing.Size(397, 79);
            this.txtPdDetalle.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoría:";
            // 
            // cbPdCategoria
            // 
            this.cbPdCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.cbPdCategoria.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPdCategoria.FormattingEnabled = true;
            this.cbPdCategoria.Location = new System.Drawing.Point(100, 114);
            this.cbPdCategoria.Name = "cbPdCategoria";
            this.cbPdCategoria.Size = new System.Drawing.Size(313, 21);
            this.cbPdCategoria.TabIndex = 10;
            // 
            // txtPdCantidadStock
            // 
            this.txtPdCantidadStock.Depth = 0;
            this.txtPdCantidadStock.Hint = "Cantidad Stock";
            this.txtPdCantidadStock.Location = new System.Drawing.Point(17, 146);
            this.txtPdCantidadStock.MaxLength = 32767;
            this.txtPdCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPdCantidadStock.Name = "txtPdCantidadStock";
            this.txtPdCantidadStock.PasswordChar = '\0';
            this.txtPdCantidadStock.SelectedText = "";
            this.txtPdCantidadStock.SelectionLength = 0;
            this.txtPdCantidadStock.SelectionStart = 0;
            this.txtPdCantidadStock.Size = new System.Drawing.Size(394, 23);
            this.txtPdCantidadStock.TabIndex = 9;
            this.txtPdCantidadStock.TabStop = false;
            this.txtPdCantidadStock.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.btnPdSalir);
            this.panel2.Controls.Add(this.btnPdEliminar);
            this.panel2.Controls.Add(this.btnPdActualizar);
            this.panel2.Controls.Add(this.btnPdNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(623, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 324);
            this.panel2.TabIndex = 7;
            // 
            // btnPdSalir
            // 
            this.btnPdSalir.AutoSize = true;
            this.btnPdSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdSalir.Depth = 0;
            this.btnPdSalir.FlatAppearance.BorderSize = 0;
            this.btnPdSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnPdSalir.Icon = null;
            this.btnPdSalir.Location = new System.Drawing.Point(40, 246);
            this.btnPdSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdSalir.Name = "btnPdSalir";
            this.btnPdSalir.Primary = true;
            this.btnPdSalir.Size = new System.Drawing.Size(72, 36);
            this.btnPdSalir.TabIndex = 3;
            this.btnPdSalir.Text = "S A L I R";
            this.btnPdSalir.UseVisualStyleBackColor = true;
            this.btnPdSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnPdEliminar
            // 
            this.btnPdEliminar.AutoSize = true;
            this.btnPdEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdEliminar.Depth = 0;
            this.btnPdEliminar.FlatAppearance.BorderSize = 0;
            this.btnPdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnPdEliminar.Icon = null;
            this.btnPdEliminar.Location = new System.Drawing.Point(23, 197);
            this.btnPdEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdEliminar.Name = "btnPdEliminar";
            this.btnPdEliminar.Primary = true;
            this.btnPdEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnPdEliminar.TabIndex = 2;
            this.btnPdEliminar.Text = "E L I M I N A R";
            this.btnPdEliminar.UseVisualStyleBackColor = true;
            // 
            // btnPdActualizar
            // 
            this.btnPdActualizar.AutoSize = true;
            this.btnPdActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdActualizar.Depth = 0;
            this.btnPdActualizar.FlatAppearance.BorderSize = 0;
            this.btnPdActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnPdActualizar.Icon = null;
            this.btnPdActualizar.Location = new System.Drawing.Point(9, 148);
            this.btnPdActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdActualizar.Name = "btnPdActualizar";
            this.btnPdActualizar.Primary = true;
            this.btnPdActualizar.Size = new System.Drawing.Size(134, 36);
            this.btnPdActualizar.TabIndex = 1;
            this.btnPdActualizar.Text = "A C T U A L I Z A R";
            this.btnPdActualizar.UseVisualStyleBackColor = true;
            // 
            // btnPdNuevo
            // 
            this.btnPdNuevo.AutoSize = true;
            this.btnPdNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdNuevo.Depth = 0;
            this.btnPdNuevo.FlatAppearance.BorderSize = 0;
            this.btnPdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnPdNuevo.Icon = null;
            this.btnPdNuevo.Location = new System.Drawing.Point(37, 99);
            this.btnPdNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdNuevo.Name = "btnPdNuevo";
            this.btnPdNuevo.Primary = true;
            this.btnPdNuevo.Size = new System.Drawing.Size(79, 36);
            this.btnPdNuevo.TabIndex = 0;
            this.btnPdNuevo.Text = "N U E V O";
            this.btnPdNuevo.UseVisualStyleBackColor = true;
            // 
            // txtImagenProducto
            // 
            this.txtImagenProducto.Depth = 0;
            this.txtImagenProducto.Hint = "Imagen Producto";
            this.txtImagenProducto.Location = new System.Drawing.Point(17, 180);
            this.txtImagenProducto.MaxLength = 32767;
            this.txtImagenProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImagenProducto.Name = "txtImagenProducto";
            this.txtImagenProducto.PasswordChar = '\0';
            this.txtImagenProducto.SelectedText = "";
            this.txtImagenProducto.SelectionLength = 0;
            this.txtImagenProducto.SelectionStart = 0;
            this.txtImagenProducto.Size = new System.Drawing.Size(394, 23);
            this.txtImagenProducto.TabIndex = 6;
            this.txtImagenProducto.TabStop = false;
            this.txtImagenProducto.UseSystemPasswordChar = false;
            // 
            // txtPdPrecioVenta
            // 
            this.txtPdPrecioVenta.Depth = 0;
            this.txtPdPrecioVenta.Hint = "Precio Venta";
            this.txtPdPrecioVenta.Location = new System.Drawing.Point(221, 81);
            this.txtPdPrecioVenta.MaxLength = 32767;
            this.txtPdPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPdPrecioVenta.Name = "txtPdPrecioVenta";
            this.txtPdPrecioVenta.PasswordChar = '\0';
            this.txtPdPrecioVenta.SelectedText = "";
            this.txtPdPrecioVenta.SelectionLength = 0;
            this.txtPdPrecioVenta.SelectionStart = 0;
            this.txtPdPrecioVenta.Size = new System.Drawing.Size(190, 23);
            this.txtPdPrecioVenta.TabIndex = 5;
            this.txtPdPrecioVenta.TabStop = false;
            this.txtPdPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtPdPrecioCompra
            // 
            this.txtPdPrecioCompra.Depth = 0;
            this.txtPdPrecioCompra.Hint = "Precio Compra";
            this.txtPdPrecioCompra.Location = new System.Drawing.Point(17, 81);
            this.txtPdPrecioCompra.MaxLength = 32767;
            this.txtPdPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPdPrecioCompra.Name = "txtPdPrecioCompra";
            this.txtPdPrecioCompra.PasswordChar = '\0';
            this.txtPdPrecioCompra.SelectedText = "";
            this.txtPdPrecioCompra.SelectionLength = 0;
            this.txtPdPrecioCompra.SelectionStart = 0;
            this.txtPdPrecioCompra.Size = new System.Drawing.Size(190, 23);
            this.txtPdPrecioCompra.TabIndex = 4;
            this.txtPdPrecioCompra.TabStop = false;
            this.txtPdPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtPdNombre
            // 
            this.txtPdNombre.Depth = 0;
            this.txtPdNombre.Hint = "Nombre";
            this.txtPdNombre.Location = new System.Drawing.Point(17, 47);
            this.txtPdNombre.MaxLength = 32767;
            this.txtPdNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPdNombre.Name = "txtPdNombre";
            this.txtPdNombre.PasswordChar = '\0';
            this.txtPdNombre.SelectedText = "";
            this.txtPdNombre.SelectionLength = 0;
            this.txtPdNombre.SelectionStart = 0;
            this.txtPdNombre.Size = new System.Drawing.Size(394, 23);
            this.txtPdNombre.TabIndex = 2;
            this.txtPdNombre.TabStop = false;
            this.txtPdNombre.UseSystemPasswordChar = false;
            // 
            // pbPdImagen
            // 
            this.pbPdImagen.Location = new System.Drawing.Point(430, 45);
            this.pbPdImagen.Name = "pbPdImagen";
            this.pbPdImagen.Size = new System.Drawing.Size(181, 237);
            this.pbPdImagen.TabIndex = 12;
            this.pbPdImagen.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(820, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPdBusqueda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPdImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgPdBusqueda;
        private MaterialSkin.Controls.MaterialRaisedButton btnPdBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPdBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnPdSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnPdEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnPdActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnPdNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImagenProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPdPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPdPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPdNombre;
        private System.Windows.Forms.ComboBox cbPdCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPdCantidadStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPdImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPdDetalle;
        private System.Windows.Forms.Label lblPdCodProducto;
        private System.Windows.Forms.Label label4;
    }
}