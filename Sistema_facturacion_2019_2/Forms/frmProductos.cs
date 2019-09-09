using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_facturacion_2019_2
{
    public partial class frmProductos : Form
    {
        Acceso_datos acceso = new Acceso_datos();
        string sentencia;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void llenarTabla()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblproductos", "");
            dgPdProducto.DataSource = dt;

            dt = acceso.Cargartabla("tblcategoria_prod", "");
            cbPdCategoria.DataSource = dt;
            cbPdCategoria.DisplayMember = "StrReferencia";
            cbPdCategoria.ValueMember = "idCategoria";
        }

        public Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtPdNombre.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtPdNombre, "Debe ingresar el nombre del producto");
                txtPdNombre.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdNombre, "");
            }

            if (txtPdReferencia.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtPdReferencia, "Debe ingresar la referencia del producto");
                txtPdReferencia.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdReferencia, "");
            }

            if (txtPdPrecioVenta.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtPdPrecioVenta, "Debe ingresar el precio de venta del producto");
                txtPdPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdPrecioVenta, "");
            }

            if (!esNumerico(txtPdPrecioVenta.Text))
            {
                epPdMensajeError.SetError(txtPdPrecioVenta, "El precio venta debe ser númerico");
                txtPdPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdPrecioVenta, "");
            }

            if (txtPdPrecioCompra.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtPdPrecioCompra, "Debe ingresar el precio de compra del producto");
                txtPdPrecioCompra.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdPrecioCompra, "");
            }

            if (!esNumerico(txtPdPrecioCompra.Text))
            {
                epPdMensajeError.SetError(txtPdPrecioCompra, "El precio compra debe ser númerico");
                txtPdPrecioCompra.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdPrecioCompra, "");
            }

            if (txtPdDetalle.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtPdDetalle, "Debe ingresar el detalle del producto");
                txtPdDetalle.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdDetalle, "");
            }

            if (txtImagenProducto.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtImagenProducto, "Debe ingresar imagén del producto");
                txtImagenProducto.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtImagenProducto, "");
            }

            if (txtPdCantidadStock.Text == string.Empty)
            {
                epPdMensajeError.SetError(txtPdCantidadStock, "Debe ingresar stock del producto");
                txtPdCantidadStock.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdCantidadStock, "");
            }

            if (!esNumerico(txtPdCantidadStock.Text))
            {
                epPdMensajeError.SetError(txtPdCantidadStock, "El stock debe ser númerico");
                txtPdCantidadStock.Focus();
                errorCampos = false;
            }
            else
            {
                epPdMensajeError.SetError(txtPdCantidadStock, "");
            }

            if (lblPdId.Text == "")
            {
                lblPdId.Text = "000";
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
            lblPdId.Text = "000";
            txtPdNombre.Text = "";
            txtPdReferencia.Text = "";
            txtPdPrecioVenta.Text = "";
            txtPdPrecioCompra.Text = "";
            txtPdCantidadStock.Text = "";
            txtImagenProducto.Text = "";
            txtPdDetalle.Text = "";
            cbPdCategoria.SelectedIndex = 0;
        }

        public Boolean guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    sentencia = $"exec spActualizarProducto '{Convert.ToInt32(lblPdId.Text)}', '{txtPdNombre.Text}', '{txtPdReferencia.Text}', '{Convert.ToDouble(txtPdPrecioCompra.Text)}', '{Convert.ToDouble(txtPdPrecioVenta.Text)}', {cbPdCategoria.SelectedValue}, '{txtPdDetalle.Text}', '{txtImagenProducto.Text}', '{Convert.ToInt32(txtPdCantidadStock.Text)}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 'sjaramillo'";
                    MessageBox.Show(acceso.EjecutarComando(sentencia));
                    llenarTabla();
                    actualizado = true;
                    nuevo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló la inserción" + ex.ToString());
                    actualizado = false;
                }
            }

            return actualizado;
        }

        public void eliminar()
        {
            if (lblPdId.Text != "000" && lblPdId.Text != "")
            {
                sentencia = $"exec spEliminarProducto '{ Convert.ToInt32(lblPdId.Text) }'";
                MessageBox.Show(acceso.EjecutarComando(sentencia));
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir de la edición?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void DgPdProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicionActual;

            posicionActual = dgPdProducto.CurrentRow.Index;
            lblPdId.Text = dgPdProducto[0, posicionActual].Value.ToString();
            txtPdNombre.Text = dgPdProducto[1, posicionActual].Value.ToString();
            txtPdReferencia.Text = dgPdProducto[2, posicionActual].Value.ToString();
            txtPdPrecioCompra.Text = dgPdProducto[3, posicionActual].Value.ToString();
            txtPdPrecioVenta.Text = dgPdProducto[4, posicionActual].Value.ToString();
            cbPdCategoria.SelectedValue = Convert.ToInt16(dgPdProducto[5, posicionActual].Value.ToString());
            txtPdDetalle.Text = dgPdProducto[6, posicionActual].Value.ToString();
            txtImagenProducto.Text = dgPdProducto[7, posicionActual].Value.ToString();
            txtPdCantidadStock.Text = dgPdProducto[8, posicionActual].Value.ToString();
        }

        private void BtnPdGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnPdEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            nuevo();
        }

        private void BtnPdNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnPdBuscar_Click(object sender, EventArgs e)
        {
            if (txtPdBusqueda.Text != "")
            {
                sentencia = $"select * from tblproductos where StrNombre like '%{txtPdBusqueda.Text}%'";
                dgPdProducto.DataSource = acceso.EjecutarComandoDatos(sentencia);
                txtPdBusqueda.Text = "";
            }
            else
            {
                llenarTabla();
            }
        }
    }
}
