namespace Sistema_facturacion_2019_2
{
    partial class frmClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtClEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgClBusqueda = new System.Windows.Forms.DataGridView();
            this.btnClBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtClBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtClEmail);
            this.panel1.Controls.Add(this.txtClTelefono);
            this.panel1.Controls.Add(this.txtClDireccion);
            this.panel1.Controls.Add(this.txtClDocumento);
            this.panel1.Controls.Add(this.txtClNombre);
            this.panel1.Location = new System.Drawing.Point(43, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 236);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.btnClSalir);
            this.panel2.Controls.Add(this.btnClEliminar);
            this.panel2.Controls.Add(this.btnClActualizar);
            this.panel2.Controls.Add(this.btnClNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 234);
            this.panel2.TabIndex = 7;
            // 
            // btnClSalir
            // 
            this.btnClSalir.AutoSize = true;
            this.btnClSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClSalir.Depth = 0;
            this.btnClSalir.FlatAppearance.BorderSize = 0;
            this.btnClSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClSalir.Icon = null;
            this.btnClSalir.Location = new System.Drawing.Point(52, 168);
            this.btnClSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClSalir.Name = "btnClSalir";
            this.btnClSalir.Primary = true;
            this.btnClSalir.Size = new System.Drawing.Size(72, 36);
            this.btnClSalir.TabIndex = 4;
            this.btnClSalir.Text = "S A L I R";
            this.btnClSalir.UseVisualStyleBackColor = true;
            this.btnClSalir.Click += new System.EventHandler(this.BtnClSalir_Click);
            // 
            // btnClEliminar
            // 
            this.btnClEliminar.AutoSize = true;
            this.btnClEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClEliminar.Depth = 0;
            this.btnClEliminar.FlatAppearance.BorderSize = 0;
            this.btnClEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClEliminar.Icon = null;
            this.btnClEliminar.Location = new System.Drawing.Point(38, 119);
            this.btnClEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClEliminar.Name = "btnClEliminar";
            this.btnClEliminar.Primary = true;
            this.btnClEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnClEliminar.TabIndex = 2;
            this.btnClEliminar.Text = "E L I M I N A R";
            this.btnClEliminar.UseVisualStyleBackColor = true;
            // 
            // btnClActualizar
            // 
            this.btnClActualizar.AutoSize = true;
            this.btnClActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClActualizar.Depth = 0;
            this.btnClActualizar.FlatAppearance.BorderSize = 0;
            this.btnClActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClActualizar.Icon = null;
            this.btnClActualizar.Location = new System.Drawing.Point(24, 70);
            this.btnClActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClActualizar.Name = "btnClActualizar";
            this.btnClActualizar.Primary = true;
            this.btnClActualizar.Size = new System.Drawing.Size(134, 36);
            this.btnClActualizar.TabIndex = 1;
            this.btnClActualizar.Text = "A C T U A L I Z A R";
            this.btnClActualizar.UseVisualStyleBackColor = true;
            // 
            // btnClNuevo
            // 
            this.btnClNuevo.AutoSize = true;
            this.btnClNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClNuevo.Depth = 0;
            this.btnClNuevo.FlatAppearance.BorderSize = 0;
            this.btnClNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClNuevo.Icon = null;
            this.btnClNuevo.Location = new System.Drawing.Point(52, 21);
            this.btnClNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClNuevo.Name = "btnClNuevo";
            this.btnClNuevo.Primary = true;
            this.btnClNuevo.Size = new System.Drawing.Size(79, 36);
            this.btnClNuevo.TabIndex = 0;
            this.btnClNuevo.Text = "N U E V O";
            this.btnClNuevo.UseVisualStyleBackColor = true;
            // 
            // txtClEmail
            // 
            this.txtClEmail.Depth = 0;
            this.txtClEmail.Hint = "Email";
            this.txtClEmail.Location = new System.Drawing.Point(17, 181);
            this.txtClEmail.MaxLength = 32767;
            this.txtClEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClEmail.Name = "txtClEmail";
            this.txtClEmail.PasswordChar = '\0';
            this.txtClEmail.SelectedText = "";
            this.txtClEmail.SelectionLength = 0;
            this.txtClEmail.SelectionStart = 0;
            this.txtClEmail.Size = new System.Drawing.Size(481, 23);
            this.txtClEmail.TabIndex = 6;
            this.txtClEmail.TabStop = false;
            this.txtClEmail.UseSystemPasswordChar = false;
            // 
            // txtClTelefono
            // 
            this.txtClTelefono.Depth = 0;
            this.txtClTelefono.Hint = "Teléfono";
            this.txtClTelefono.Location = new System.Drawing.Point(17, 141);
            this.txtClTelefono.MaxLength = 32767;
            this.txtClTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClTelefono.Name = "txtClTelefono";
            this.txtClTelefono.PasswordChar = '\0';
            this.txtClTelefono.SelectedText = "";
            this.txtClTelefono.SelectionLength = 0;
            this.txtClTelefono.SelectionStart = 0;
            this.txtClTelefono.Size = new System.Drawing.Size(481, 23);
            this.txtClTelefono.TabIndex = 5;
            this.txtClTelefono.TabStop = false;
            this.txtClTelefono.UseSystemPasswordChar = false;
            // 
            // txtClDireccion
            // 
            this.txtClDireccion.Depth = 0;
            this.txtClDireccion.Hint = "Dirección";
            this.txtClDireccion.Location = new System.Drawing.Point(17, 101);
            this.txtClDireccion.MaxLength = 32767;
            this.txtClDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClDireccion.Name = "txtClDireccion";
            this.txtClDireccion.PasswordChar = '\0';
            this.txtClDireccion.SelectedText = "";
            this.txtClDireccion.SelectionLength = 0;
            this.txtClDireccion.SelectionStart = 0;
            this.txtClDireccion.Size = new System.Drawing.Size(481, 23);
            this.txtClDireccion.TabIndex = 4;
            this.txtClDireccion.TabStop = false;
            this.txtClDireccion.UseSystemPasswordChar = false;
            // 
            // txtClDocumento
            // 
            this.txtClDocumento.Depth = 0;
            this.txtClDocumento.Hint = "Documento";
            this.txtClDocumento.Location = new System.Drawing.Point(17, 21);
            this.txtClDocumento.MaxLength = 32767;
            this.txtClDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClDocumento.Name = "txtClDocumento";
            this.txtClDocumento.PasswordChar = '\0';
            this.txtClDocumento.SelectedText = "";
            this.txtClDocumento.SelectionLength = 0;
            this.txtClDocumento.SelectionStart = 0;
            this.txtClDocumento.Size = new System.Drawing.Size(481, 23);
            this.txtClDocumento.TabIndex = 3;
            this.txtClDocumento.TabStop = false;
            this.txtClDocumento.UseSystemPasswordChar = false;
            // 
            // txtClNombre
            // 
            this.txtClNombre.Depth = 0;
            this.txtClNombre.Hint = "Nombre";
            this.txtClNombre.Location = new System.Drawing.Point(17, 61);
            this.txtClNombre.MaxLength = 32767;
            this.txtClNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClNombre.Name = "txtClNombre";
            this.txtClNombre.PasswordChar = '\0';
            this.txtClNombre.SelectedText = "";
            this.txtClNombre.SelectionLength = 0;
            this.txtClNombre.SelectionStart = 0;
            this.txtClNombre.Size = new System.Drawing.Size(481, 23);
            this.txtClNombre.TabIndex = 2;
            this.txtClNombre.TabStop = false;
            this.txtClNombre.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(308, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "C L I E N T E S";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgClBusqueda);
            this.panel3.Controls.Add(this.btnClBuscar);
            this.panel3.Controls.Add(this.txtClBusqueda);
            this.panel3.Location = new System.Drawing.Point(16, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 216);
            this.panel3.TabIndex = 9;
            // 
            // dgClBusqueda
            // 
            this.dgClBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgClBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgClBusqueda.Location = new System.Drawing.Point(0, 57);
            this.dgClBusqueda.Name = "dgClBusqueda";
            this.dgClBusqueda.Size = new System.Drawing.Size(777, 157);
            this.dgClBusqueda.TabIndex = 11;
            // 
            // btnClBuscar
            // 
            this.btnClBuscar.AutoSize = true;
            this.btnClBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClBuscar.Depth = 0;
            this.btnClBuscar.FlatAppearance.BorderSize = 0;
            this.btnClBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClBuscar.Icon = null;
            this.btnClBuscar.Location = new System.Drawing.Point(600, 15);
            this.btnClBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClBuscar.Name = "btnClBuscar";
            this.btnClBuscar.Primary = true;
            this.btnClBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnClBuscar.TabIndex = 9;
            this.btnClBuscar.Text = "B U S C A R";
            this.btnClBuscar.UseVisualStyleBackColor = true;
            // 
            // txtClBusqueda
            // 
            this.txtClBusqueda.Depth = 0;
            this.txtClBusqueda.Hint = "Buscar Cliente";
            this.txtClBusqueda.Location = new System.Drawing.Point(45, 21);
            this.txtClBusqueda.MaxLength = 32767;
            this.txtClBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClBusqueda.Name = "txtClBusqueda";
            this.txtClBusqueda.PasswordChar = '\0';
            this.txtClBusqueda.SelectedText = "";
            this.txtClBusqueda.SelectionLength = 0;
            this.txtClBusqueda.SelectionStart = 0;
            this.txtClBusqueda.Size = new System.Drawing.Size(481, 23);
            this.txtClBusqueda.TabIndex = 10;
            this.txtClBusqueda.TabStop = false;
            this.txtClBusqueda.UseSystemPasswordChar = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(824, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnClEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnClActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnClNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgClBusqueda;
        private MaterialSkin.Controls.MaterialRaisedButton btnClBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClBusqueda;
        private MaterialSkin.Controls.MaterialRaisedButton btnClSalir;
    }
}