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
    public partial class frmSeguridad : Form
    {
        Acceso_datos acceso = new Acceso_datos();
        string sentencia;
        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void llenarComboEmpleados()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblempleados", "");

            cbSgEmpleado.DataSource = dt;
            cbSgEmpleado.DisplayMember = "strNombre";
            cbSgEmpleado.ValueMember = "IdEmpleado";
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtSgUsuario.Text == string.Empty)
            {
                epSgMensajeError.SetError(txtSgUsuario, "Debe ingresar el nombre de usuario");
                txtSgUsuario.Focus();
                errorCampos = false;
            }
            else
            {
                epSgMensajeError.SetError(txtSgUsuario, "");
            }

            if (txtSgClave.Text == string.Empty)
            {
                epSgMensajeError.SetError(txtSgClave, "Debe ingresar la contraseña");
                txtSgClave.Focus();
                errorCampos = false;
            }
            else
            {
                epSgMensajeError.SetError(txtSgClave, "");
            }

            return errorCampos;
        }

        public void nuevo()
        {
            txtSgUsuario.Text = "";
            txtSgClave.Text = "";
        }

        public Boolean guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    sentencia = $"exec spActualizarSeguridad '{Convert.ToInt32(cbSgEmpleado.SelectedValue)}', '{txtSgUsuario.Text}', '{txtSgClave.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 'sjaramillo'";
                    MessageBox.Show(acceso.EjecutarComando(sentencia));
                    actualizado = true;
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
            sentencia = $"exec spEliminarSeguridad '{ Convert.ToInt32(cbSgEmpleado.SelectedValue) }'";
            MessageBox.Show(acceso.EjecutarComando(sentencia));
        }

        public void consultar()
        {
            DataTable dt = new DataTable();
            sentencia = $"select StrUsuario, StrClave from tblseguridad where IdEmpleado = '{ cbSgEmpleado.SelectedValue.ToString() }'";
            dt = acceso.EjecutarComandoDatos(sentencia);
            if (dt.Rows.Count > 0)
            {
                txtSgUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtSgClave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                nuevo();
            }
        }

        private void BtnSgSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir de la edición?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            llenarComboEmpleados();
        }

        private void BtnSgGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            nuevo();
        }

        private void BtnSgEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            nuevo();
        }

        private void BtnSgConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
