using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_facturacion_2019_2.Forms
{
    public partial class frmFacturas : Form
    {
        Acceso_datos acceso = new Acceso_datos();
        string sentencia;

        private void llenarTabla()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblfacturas", "");
            dgFcFactura.DataSource = dt;

            dt = acceso.Cargartabla("tblclientes", "");
            cbFcCliente.DataSource = dt;
            cbFcCliente.DisplayMember = "StrNombre";
            cbFcCliente.ValueMember = "IdCliente";

            dt = acceso.Cargartabla("tblestado_factura", "");
            cbFcEstadoFactura.DataSource = dt;
            cbFcEstadoFactura.DisplayMember = "strEstado";
            cbFcEstadoFactura.ValueMember = "IdEstado";

            dt = acceso.Cargartabla("tblempleados", "");
            cbFcEmpleado.DataSource = dt;
            cbFcEmpleado.DisplayMember = "strNombre";
            cbFcEmpleado.ValueMember = "IdEmpleado";

            dt = acceso.Cargartabla("tblproductos", "");
            cbFdProducto.DataSource = dt;
            cbFdProducto.DisplayMember = "StrNombre";
            cbFdProducto.ValueMember = "IdProducto";
        }

        public Boolean validarFactura()
        {
            Boolean errorCampos = true;

            if (txtFcDescuento.Text == string.Empty)
            {
                epFcMensajeError.SetError(txtFcDescuento, "Debe ingresar el detalle de la factura");
                txtFcDescuento.Focus();
                errorCampos = false;
            }
            else
            {
                epFcMensajeError.SetError(txtFcDescuento, "");
            }


            if (!esNumerico(txtFcDescuento.Text))
            {
                epFcMensajeError.SetError(txtFcDescuento, "El detalle debe ser un número");
                txtFcDescuento.Focus();
                errorCampos = false;
            }
            else
            {
                epFcMensajeError.SetError(txtFcDescuento, "");
            }

            if (txtFcImpuesto.Text == string.Empty)
            {
                epFcMensajeError.SetError(txtFcImpuesto, "Debe ingresar el impuest de la factura");
                txtFcImpuesto.Focus();
                errorCampos = false;
            }
            else
            {
                epFcMensajeError.SetError(txtFcImpuesto, "");
            }

            if (!esNumerico(txtFcImpuesto.Text))
            {
                epFcMensajeError.SetError(txtFcImpuesto, "El impuesto debe ser un número");
                txtFcImpuesto.Focus();
                errorCampos = false;
            }
            else
            {
                epFcMensajeError.SetError(txtFcImpuesto, "");
            }

            if (lblFcId.Text == "")
            {
                lblFcId.Text = "000";
            }

            return errorCampos;
        }

        public Boolean validarDetalle()
        {
            Boolean errorCampos = true;

            if (txtDfCantidad.Text == string.Empty)
            {
                epFcMensajeError.SetError(txtDfCantidad, "Debe ingresar la cantidad a comprar");
                txtDfCantidad.Focus();
                errorCampos = false;
            }
            else
            {
                epFcMensajeError.SetError(txtDfCantidad, "");
            }


            if (!esNumerico(txtDfCantidad.Text))
            {
                epFcMensajeError.SetError(txtDfCantidad, "La cantidad debe ser un número");
                txtDfCantidad.Focus();
                errorCampos = false;
            }
            else
            {
                epFcMensajeError.SetError(txtDfCantidad, "");
            }

            return errorCampos;
        }


        private Boolean esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void nuevo()
        {
            lblFcId.Text = "000";
            dtpFcFecha.Value = DateTime.Now;
            cbFcCliente.SelectedIndex = 0;
            cbFcEmpleado.SelectedIndex = 0;
            txtFcDescuento.Text = "";
            txtFcImpuesto.Text = "";
            cbFcEstadoFactura.SelectedIndex = 0;

            cbFdProducto.SelectedIndex = 0;
            txtDfCantidad.Text = "";
            txtDfPrecio.Text = "";            
        }

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void BtnFcSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
