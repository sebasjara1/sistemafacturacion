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
    public partial class frmEmpleados : Form
    {
        Acceso_datos acceso = new Acceso_datos();
        string sentencia;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void llenarTabla()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblempleados", "");
            dgEmEmpleado.DataSource = dt;

            dt = acceso.Cargartabla("tblroles", "");
            cbEmRol.DataSource = dt;
            cbEmRol.DisplayMember = "StrDescripcion";
            cbEmRol.ValueMember = "IdRolEmpleado";
        }

        public Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtEmNombre.Text == string.Empty)
            {
                epMensajeError.SetError(txtEmNombre, "Debe ingresar el nombre del empleado");
                txtEmNombre.Focus();
                errorCampos = false;
            } else
            {
                epMensajeError.SetError(txtEmNombre, "");
            }

            if (txtEmDocumento.Text == string.Empty)
            {
                epMensajeError.SetError(txtEmDocumento, "Debe ingresar el documento del empleado");
                txtEmDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                epMensajeError.SetError(txtEmDocumento, "");
            }

            if (!esNumerico(txtEmDocumento.Text))
            {
                epMensajeError.SetError(txtEmDocumento, "El documento debe ser un número");
                txtEmDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                epMensajeError.SetError(txtEmDocumento, "");
            }

            if (txtEmDireccion.Text == string.Empty)
            {
                epMensajeError.SetError(txtEmDireccion, "Debe ingresar la dirección del empleado");
                txtEmDireccion.Focus();
                errorCampos = false;
            }
            else
            {
                epMensajeError.SetError(txtEmDireccion, "");
            }

            if (txtEmTelefono.Text == string.Empty)
            {
                epMensajeError.SetError(txtEmTelefono, "Debe ingresar el teléfono del empleado");
                txtEmTelefono.Focus();
                errorCampos = false;
            }
            else
            {
                epMensajeError.SetError(txtEmTelefono, "");
            }

            if (txtEmEmail.Text == string.Empty)
            {
                epMensajeError.SetError(txtEmEmail, "Debe ingresar el email del empleado");
                txtEmEmail.Focus();
                errorCampos = false;
            }
            else
            {
                epMensajeError.SetError(txtEmEmail, "");
            }

            if (txtEmDatosAdicionales.Text == string.Empty)
            {
                epMensajeError.SetError(txtEmDatosAdicionales, "Debe ingresar los datos adicionales del empleado");
                txtEmDatosAdicionales.Focus();
                errorCampos = false;
            }
            else
            {
                epMensajeError.SetError(txtEmDatosAdicionales, "");
            }

            if (lblEmId.Text == "")
            {
                lblEmId.Text = "000";
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
            lblEmId.Text = "000";
            txtEmNombre.Text = "";
            txtEmDocumento.Text = "";
            txtEmDireccion.Text = "";
            txtEmTelefono.Text = "";
            txtEmEmail.Text = "";
            cbEmRol.SelectedIndex = 0;
            dtpEmFechaIngreso.Value = DateTime.Now;
            dtpEmFechaRetiro.Value = Convert.ToDateTime("01/01/1900");
            txtEmDatosAdicionales.Text = "";
        }

        public Boolean guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {                    
                    sentencia = $"exec spActualizarEmpleado '{Convert.ToInt32(lblEmId.Text)}', '{txtEmNombre.Text}', '{Convert.ToInt32(txtEmDocumento.Text)}', '{txtEmDireccion.Text}', '{txtEmTelefono.Text}', '{txtEmEmail.Text}', '{cbEmRol.SelectedValue}', '{dtpEmFechaIngreso.Text}', '{dtpEmFechaRetiro.Text}', '{txtEmDatosAdicionales.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 'sjaramillo'";
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
            if (lblEmId.Text != "000" && lblEmId.Text != "")
            {
                sentencia = $"exec spEliminarEmpleado '{ Convert.ToInt32(lblEmId.Text) }'";
                MessageBox.Show(acceso.EjecutarComando(sentencia));
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }

           

        private void BtnEmGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnEmEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            nuevo();
        }

        private void BtnEmNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnUsSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir de la edición?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dtpEmFechaRetiro.Value = Convert.ToDateTime("01/01/1900");
        }

        private void DgEmEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicionActual;

            posicionActual = dgEmEmpleado.CurrentRow.Index;
            lblEmId.Text = dgEmEmpleado[0, posicionActual].Value.ToString();
            txtEmNombre.Text = dgEmEmpleado[1, posicionActual].Value.ToString();
            txtEmDocumento.Text = dgEmEmpleado[2, posicionActual].Value.ToString();
            txtEmDireccion.Text = dgEmEmpleado[3, posicionActual].Value.ToString();
            txtEmTelefono.Text = dgEmEmpleado[4, posicionActual].Value.ToString();
            txtEmEmail.Text = dgEmEmpleado[5, posicionActual].Value.ToString();
            cbEmRol.SelectedValue = Convert.ToInt16(dgEmEmpleado[6, posicionActual].Value.ToString());
            dtpEmFechaIngreso.Value = Convert.ToDateTime(dgEmEmpleado[7, posicionActual].Value.ToString());

            if (dgEmEmpleado[8, posicionActual].Value.ToString() != "")
            {
                dtpEmFechaRetiro.Value = Convert.ToDateTime(dgEmEmpleado[8, posicionActual].Value.ToString());
            }
            else
            {
                dtpEmFechaRetiro.Value = Convert.ToDateTime("01/01/1900");
            }

            txtEmDatosAdicionales.Text = dgEmEmpleado[9, posicionActual].Value.ToString();
        }

        private void BtnEmBuscar_Click(object sender, EventArgs e)
        {
            if (txtEmBusqueda.Text != "")
            {
                sentencia = $"select * from tblempleados where strNombre like '%{txtEmBusqueda.Text}%'";
                dgEmEmpleado.DataSource = acceso.EjecutarComandoDatos(sentencia);
                txtEmBusqueda.Text = "";
            }
            else
            {
                llenarTabla();
            }
        }
    }
}
