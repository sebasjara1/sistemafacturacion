namespace Sistema_facturacion_2019_2
{
    partial class frmCategorias
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
            this.dgCgBusqueda = new System.Windows.Forms.DataGridView();
            this.btnCgBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCgBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPdCodProducto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCgSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCgEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCgActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCgNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCgNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCgBusqueda)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgCgBusqueda);
            this.panel3.Controls.Add(this.btnCgBuscar);
            this.panel3.Controls.Add(this.txtCgBusqueda);
            this.panel3.Location = new System.Drawing.Point(18, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 197);
            this.panel3.TabIndex = 12;
            // 
            // dgCgBusqueda
            // 
            this.dgCgBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgCgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCgBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCgBusqueda.Location = new System.Drawing.Point(0, 63);
            this.dgCgBusqueda.Name = "dgCgBusqueda";
            this.dgCgBusqueda.Size = new System.Drawing.Size(777, 132);
            this.dgCgBusqueda.TabIndex = 11;
            // 
            // btnCgBuscar
            // 
            this.btnCgBuscar.AutoSize = true;
            this.btnCgBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCgBuscar.Depth = 0;
            this.btnCgBuscar.FlatAppearance.BorderSize = 0;
            this.btnCgBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCgBuscar.Icon = null;
            this.btnCgBuscar.Location = new System.Drawing.Point(600, 15);
            this.btnCgBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCgBuscar.Name = "btnCgBuscar";
            this.btnCgBuscar.Primary = true;
            this.btnCgBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnCgBuscar.TabIndex = 9;
            this.btnCgBuscar.Text = "B U S C A R";
            this.btnCgBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCgBusqueda
            // 
            this.txtCgBusqueda.Depth = 0;
            this.txtCgBusqueda.Hint = "Buscar Categoría";
            this.txtCgBusqueda.Location = new System.Drawing.Point(45, 21);
            this.txtCgBusqueda.MaxLength = 32767;
            this.txtCgBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCgBusqueda.Name = "txtCgBusqueda";
            this.txtCgBusqueda.PasswordChar = '\0';
            this.txtCgBusqueda.SelectedText = "";
            this.txtCgBusqueda.SelectionLength = 0;
            this.txtCgBusqueda.SelectionStart = 0;
            this.txtCgBusqueda.Size = new System.Drawing.Size(481, 23);
            this.txtCgBusqueda.TabIndex = 10;
            this.txtCgBusqueda.TabStop = false;
            this.txtCgBusqueda.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(234, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADMINISTRACIÓN DE CATEGORÍAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPdCodProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtCgNombre);
            this.panel1.Location = new System.Drawing.Point(45, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 236);
            this.panel1.TabIndex = 10;
            // 
            // lblPdCodProducto
            // 
            this.lblPdCodProducto.AutoSize = true;
            this.lblPdCodProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdCodProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lblPdCodProducto.Location = new System.Drawing.Point(204, 86);
            this.lblPdCodProducto.Name = "lblPdCodProducto";
            this.lblPdCodProducto.Size = new System.Drawing.Size(0, 20);
            this.lblPdCodProducto.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Código Referencia:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.btnCgSalir);
            this.panel2.Controls.Add(this.btnCgEliminar);
            this.panel2.Controls.Add(this.btnCgActualizar);
            this.panel2.Controls.Add(this.btnCgNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 234);
            this.panel2.TabIndex = 7;
            // 
            // btnCgSalir
            // 
            this.btnCgSalir.AutoSize = true;
            this.btnCgSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCgSalir.Depth = 0;
            this.btnCgSalir.FlatAppearance.BorderSize = 0;
            this.btnCgSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCgSalir.Icon = null;
            this.btnCgSalir.Location = new System.Drawing.Point(55, 168);
            this.btnCgSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCgSalir.Name = "btnCgSalir";
            this.btnCgSalir.Primary = true;
            this.btnCgSalir.Size = new System.Drawing.Size(72, 36);
            this.btnCgSalir.TabIndex = 3;
            this.btnCgSalir.Text = "S A L I R";
            this.btnCgSalir.UseVisualStyleBackColor = true;
            this.btnCgSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCgEliminar
            // 
            this.btnCgEliminar.AutoSize = true;
            this.btnCgEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCgEliminar.Depth = 0;
            this.btnCgEliminar.FlatAppearance.BorderSize = 0;
            this.btnCgEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCgEliminar.Icon = null;
            this.btnCgEliminar.Location = new System.Drawing.Point(38, 119);
            this.btnCgEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCgEliminar.Name = "btnCgEliminar";
            this.btnCgEliminar.Primary = true;
            this.btnCgEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnCgEliminar.TabIndex = 2;
            this.btnCgEliminar.Text = "E L I M I N A R";
            this.btnCgEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCgActualizar
            // 
            this.btnCgActualizar.AutoSize = true;
            this.btnCgActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCgActualizar.Depth = 0;
            this.btnCgActualizar.FlatAppearance.BorderSize = 0;
            this.btnCgActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCgActualizar.Icon = null;
            this.btnCgActualizar.Location = new System.Drawing.Point(24, 70);
            this.btnCgActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCgActualizar.Name = "btnCgActualizar";
            this.btnCgActualizar.Primary = true;
            this.btnCgActualizar.Size = new System.Drawing.Size(134, 36);
            this.btnCgActualizar.TabIndex = 1;
            this.btnCgActualizar.Text = "A C T U A L I Z A R";
            this.btnCgActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCgNuevo
            // 
            this.btnCgNuevo.AutoSize = true;
            this.btnCgNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCgNuevo.Depth = 0;
            this.btnCgNuevo.FlatAppearance.BorderSize = 0;
            this.btnCgNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCgNuevo.Icon = null;
            this.btnCgNuevo.Location = new System.Drawing.Point(52, 21);
            this.btnCgNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCgNuevo.Name = "btnCgNuevo";
            this.btnCgNuevo.Primary = true;
            this.btnCgNuevo.Size = new System.Drawing.Size(79, 36);
            this.btnCgNuevo.TabIndex = 0;
            this.btnCgNuevo.Text = "N U E V O";
            this.btnCgNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCgNombre
            // 
            this.txtCgNombre.Depth = 0;
            this.txtCgNombre.Hint = "Nombre";
            this.txtCgNombre.Location = new System.Drawing.Point(17, 119);
            this.txtCgNombre.MaxLength = 32767;
            this.txtCgNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCgNombre.Name = "txtCgNombre";
            this.txtCgNombre.PasswordChar = '\0';
            this.txtCgNombre.SelectedText = "";
            this.txtCgNombre.SelectionLength = 0;
            this.txtCgNombre.SelectionStart = 0;
            this.txtCgNombre.Size = new System.Drawing.Size(481, 23);
            this.txtCgNombre.TabIndex = 2;
            this.txtCgNombre.TabStop = false;
            this.txtCgNombre.UseSystemPasswordChar = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(861, 576);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCgBusqueda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgCgBusqueda;
        private MaterialSkin.Controls.MaterialRaisedButton btnCgBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCgBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnCgSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnCgEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCgActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCgNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCgNombre;
        private System.Windows.Forms.Label lblPdCodProducto;
        private System.Windows.Forms.Label label4;
    }
}