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
    public partial class frmCategorias : Form
    {

        Acceso_datos acceso = new Acceso_datos();
        string sentencia;

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void llenarTabla()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblcategoria_prod", "");
            dgCgCategoria.DataSource = dt;
        }

        public Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtCgReferencia.Text == string.Empty)
            {
                epCgMensajeError.SetError(txtCgReferencia, "Debe ingresar la categoría");
                txtCgReferencia.Focus();
                errorCampos = false;
            }
            else
            {
                epCgMensajeError.SetError(txtCgReferencia, "");
            }

            if (txtCgDescripcion.Text == string.Empty)
            {
                epCgMensajeError.SetError(txtCgDescripcion, "Debe ingresar la descripción de la categoría");
                txtCgDescripcion.Focus();
                errorCampos = false;
            }
            else
            {
                epCgMensajeError.SetError(txtCgDescripcion, "");
            }

            if (lblCtId.Text == "")
            {
                lblCtId.Text = "000";
            }

            return errorCampos;
        }

        public void nuevo()
        {
            lblCtId.Text = "000";
            txtCgReferencia.Text = "";
            txtCgDescripcion.Text = "";
        }

        public Boolean guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    sentencia = $"exec spActualizarCategoriaProducto '{Convert.ToInt32(lblCtId.Text)}', '{txtCgReferencia.Text}', '{txtCgDescripcion.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 'sjaramillo'";
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
            if (lblCtId.Text != "000" && lblCtId.Text != "")
            {
                sentencia = $"exec spEliminarCategoriaProducto '{ Convert.ToInt32(lblCtId.Text) }'";
                MessageBox.Show(acceso.EjecutarComando(sentencia));
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría");
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

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
        private void DgCgCategoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicionActual;

            posicionActual = dgCgCategoria.CurrentRow.Index;
            lblCtId.Text = dgCgCategoria[0, posicionActual].Value.ToString();
            txtCgReferencia.Text = dgCgCategoria[1, posicionActual].Value.ToString();
            txtCgDescripcion.Text = dgCgCategoria[2, posicionActual].Value.ToString();
        }

        private void BtnCgGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnCgEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            nuevo();
        }

        private void BtnCgNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnCgBuscar_Click(object sender, EventArgs e)
        {
            if (txtCgBusqueda.Text != "")
            {
                sentencia = $"select * from tblcategoria_prod where StrReferencia like '%{txtCgBusqueda.Text}%'";
                dgCgCategoria.DataSource = acceso.EjecutarComandoDatos(sentencia);
                txtCgBusqueda.Text = "";
            }
            else
            {
                llenarTabla();
            }
        }
    }
}
