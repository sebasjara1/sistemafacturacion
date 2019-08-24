using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_facturacion_2019_2
{
    public partial class frmPrincipal : MaterialForm
    {
        private void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmCliente = new frmClientes();
            AbrirForm(frmCliente);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frmProducto = new frmProductos();
            AbrirForm(frmProducto);
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategoria = new frmCategorias();
            AbrirForm(frmCategoria);
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            Forms.frmEmpleados frmEmpleado = new Forms.frmEmpleados();
            AbrirForm(frmEmpleado);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            Forms.frmRoles frmRol = new Forms.frmRoles();
            AbrirForm(frmRol);
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            Forms.frmSeguridad frmSeg = new Forms.frmSeguridad();
            AbrirForm(frmSeg);
        }
    }
}
