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
    public partial class frmClientes : Form
    {
        Acceso_datos acceso = new Acceso_datos();
        string sentencia;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void llenarTabla()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblclientes", "");
            dgClCliente.DataSource = dt;
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

        public Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtClNombre.Text == string.Empty)
            {
                epClMensajeError.SetError(txtClNombre, "Debe ingresar el nombre del cliente");
                txtClNombre.Focus();
                errorCampos = false;
            }
            else
            {
                epClMensajeError.SetError(txtClNombre, "");
            }

            if (txtClDocumento.Text == string.Empty)
            {
                epClMensajeError.SetError(txtClDocumento, "Debe ingresar el documento del cliente");
                txtClDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                epClMensajeError.SetError(txtClDocumento, "");
            }

            if (!esNumerico(txtClDocumento.Text))
            {
                epClMensajeError.SetError(txtClDocumento, "El documento debe ser un número");
                txtClDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                epClMensajeError.SetError(txtClDocumento, "");
            }

            if (txtClDireccion.Text == string.Empty)
            {
                epClMensajeError.SetError(txtClDireccion, "Debe ingresar la dirección del cliente");
                txtClDireccion.Focus();
                errorCampos = false;
            }
            else
            {
                epClMensajeError.SetError(txtClDireccion, "");
            }

            if (txtClTelefono.Text == string.Empty)
            {
                epClMensajeError.SetError(txtClTelefono, "Debe ingresar el teléfono del cliente");
                txtClTelefono.Focus();
                errorCampos = false;
            }
            else
            {
                epClMensajeError.SetError(txtClTelefono, "");
            }

            if (txtClEmail.Text == string.Empty)
            {
                epClMensajeError.SetError(txtClEmail, "Debe ingresar el email del cliente");
                txtClEmail.Focus();
                errorCampos = false;
            }
            else
            {
                epClMensajeError.SetError(txtClEmail, "");
            }


            if (lblClId.Text == "")
            {
                lblClId.Text = "000";
            }

            return errorCampos;

        }

        public void nuevo()
        {
            lblClId.Text = "000";
            txtClNombre.Text = "";
            txtClDocumento.Text = "";
            txtClDireccion.Text = "";
            txtClTelefono.Text = "";
            txtClEmail.Text = "";
        }

        public Boolean guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    sentencia = $"exec spActualizarClientes '{Convert.ToInt32(lblClId.Text)}', '{txtClNombre.Text}', '{Convert.ToInt32(txtClDocumento.Text)}', '{txtClDireccion.Text}', '{txtClTelefono.Text}', '{txtClEmail.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 'sjaramillo'";
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
            if (lblClId.Text != "000" && lblClId.Text != string.Empty)
            {
                sentencia = $"exec spEliminarClientes '{ Convert.ToInt32(lblClId.Text) }'";
                MessageBox.Show(acceso.EjecutarComando(sentencia));
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void BtnClSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir de la edición?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnClNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnClActualizar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnClEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            nuevo();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void DgClCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicionActual;

            posicionActual = dgClCliente.CurrentRow.Index;
            lblClId.Text = dgClCliente[0, posicionActual].Value.ToString();
            txtClNombre.Text = dgClCliente[1, posicionActual].Value.ToString();
            txtClDocumento.Text = dgClCliente[2, posicionActual].Value.ToString();
            txtClDireccion.Text = dgClCliente[3, posicionActual].Value.ToString();
            txtClTelefono.Text = dgClCliente[4, posicionActual].Value.ToString();
            txtClEmail.Text = dgClCliente[5, posicionActual].Value.ToString();
        }

        private void BtnClBuscar_Click(object sender, EventArgs e)
        {
            if (txtClBusqueda.Text != "")
            {
                sentencia = $"select * from tblclientes where StrNombre like '%{txtClBusqueda.Text}%'";
                dgClCliente.DataSource = acceso.EjecutarComandoDatos(sentencia);
                txtClBusqueda.Text = "";
            }
            else
            {
                llenarTabla();
            }
        }
    }
}
