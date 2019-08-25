namespace Sistema_facturacion_2019_2.Forms
{
    partial class frmRoles
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtRlDetalle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRlSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRlEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRlGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRlConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtRlDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(340, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "R O L E S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRlDetalle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtRlDescripcion);
            this.panel1.Location = new System.Drawing.Point(54, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 236);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(16, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Detalle Rol:";
            // 
            // txtRlDetalle
            // 
            this.txtRlDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.txtRlDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRlDetalle.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRlDetalle.Location = new System.Drawing.Point(19, 128);
            this.txtRlDetalle.Multiline = true;
            this.txtRlDetalle.Name = "txtRlDetalle";
            this.txtRlDetalle.Size = new System.Drawing.Size(481, 45);
            this.txtRlDetalle.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.btnRlSalir);
            this.panel2.Controls.Add(this.btnRlEliminar);
            this.panel2.Controls.Add(this.btnRlGuardar);
            this.panel2.Controls.Add(this.btnRlConsultar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(533, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 234);
            this.panel2.TabIndex = 7;
            // 
            // btnRlSalir
            // 
            this.btnRlSalir.AutoSize = true;
            this.btnRlSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRlSalir.Depth = 0;
            this.btnRlSalir.FlatAppearance.BorderSize = 0;
            this.btnRlSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRlSalir.Icon = null;
            this.btnRlSalir.Location = new System.Drawing.Point(55, 173);
            this.btnRlSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRlSalir.Name = "btnRlSalir";
            this.btnRlSalir.Primary = true;
            this.btnRlSalir.Size = new System.Drawing.Size(72, 36);
            this.btnRlSalir.TabIndex = 3;
            this.btnRlSalir.Text = "S A L I R";
            this.btnRlSalir.UseVisualStyleBackColor = true;
            this.btnRlSalir.Click += new System.EventHandler(this.BtnRlSalir_Click);
            // 
            // btnRlEliminar
            // 
            this.btnRlEliminar.AutoSize = true;
            this.btnRlEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRlEliminar.Depth = 0;
            this.btnRlEliminar.FlatAppearance.BorderSize = 0;
            this.btnRlEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRlEliminar.Icon = null;
            this.btnRlEliminar.Location = new System.Drawing.Point(38, 124);
            this.btnRlEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRlEliminar.Name = "btnRlEliminar";
            this.btnRlEliminar.Primary = true;
            this.btnRlEliminar.Size = new System.Drawing.Size(107, 36);
            this.btnRlEliminar.TabIndex = 2;
            this.btnRlEliminar.Text = "E L I M I N A R";
            this.btnRlEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRlGuardar
            // 
            this.btnRlGuardar.AutoSize = true;
            this.btnRlGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRlGuardar.Depth = 0;
            this.btnRlGuardar.FlatAppearance.BorderSize = 0;
            this.btnRlGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRlGuardar.Icon = null;
            this.btnRlGuardar.Location = new System.Drawing.Point(39, 75);
            this.btnRlGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRlGuardar.Name = "btnRlGuardar";
            this.btnRlGuardar.Primary = true;
            this.btnRlGuardar.Size = new System.Drawing.Size(104, 36);
            this.btnRlGuardar.TabIndex = 1;
            this.btnRlGuardar.Text = "G U A R D A R";
            this.btnRlGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRlConsultar
            // 
            this.btnRlConsultar.AutoSize = true;
            this.btnRlConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRlConsultar.Depth = 0;
            this.btnRlConsultar.FlatAppearance.BorderSize = 0;
            this.btnRlConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRlConsultar.Icon = null;
            this.btnRlConsultar.Location = new System.Drawing.Point(28, 24);
            this.btnRlConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRlConsultar.Name = "btnRlConsultar";
            this.btnRlConsultar.Primary = true;
            this.btnRlConsultar.Size = new System.Drawing.Size(127, 36);
            this.btnRlConsultar.TabIndex = 0;
            this.btnRlConsultar.Text = "C O N S U L T A R";
            this.btnRlConsultar.UseVisualStyleBackColor = true;
            // 
            // txtRlDescripcion
            // 
            this.txtRlDescripcion.Depth = 0;
            this.txtRlDescripcion.Hint = "Descripción";
            this.txtRlDescripcion.Location = new System.Drawing.Point(20, 63);
            this.txtRlDescripcion.MaxLength = 32767;
            this.txtRlDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRlDescripcion.Name = "txtRlDescripcion";
            this.txtRlDescripcion.PasswordChar = '\0';
            this.txtRlDescripcion.SelectedText = "";
            this.txtRlDescripcion.SelectionLength = 0;
            this.txtRlDescripcion.SelectionStart = 0;
            this.txtRlDescripcion.Size = new System.Drawing.Size(481, 23);
            this.txtRlDescripcion.TabIndex = 2;
            this.txtRlDescripcion.TabStop = false;
            this.txtRlDescripcion.UseSystemPasswordChar = false;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(824, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoles";
            this.Text = "frmRoles";
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
        private MaterialSkin.Controls.MaterialRaisedButton btnRlSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnRlEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRlGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRlConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRlDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRlDetalle;
    }
}