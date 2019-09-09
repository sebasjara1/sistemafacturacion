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
    public partial class frmRoles : Form
    {
        Acceso_datos acceso = new Acceso_datos();
        string sentencia;

        public frmRoles()
        {
            InitializeComponent();
        }

        private void llenarTabla()
        {
            DataTable dt = new DataTable();
            dt = acceso.Cargartabla("tblroles", "");
            dgRlRol.DataSource = dt;
        }

        public void nuevo()
        {
            lblRlId.Text = "000";
            txtRlDescripcion.Text = "";
        }

            public Boolean validar()
        {
            Boolean errorCampos = true;

            if (txtRlDescripcion.Text == string.Empty)
            {
                epRlMensajeError.SetError(txtRlDescripcion, "Debe ingresar la descripción del rol");
                txtRlDescripcion.Focus();
                errorCampos = false;
            }
            else
            {
                epRlMensajeError.SetError(txtRlDescripcion, "");
            }

            if (lblRlId.Text == "")
            {
                lblRlId.Text = "000";
            }

            return errorCampos;
        }

        public Boolean guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    sentencia = $"exec spActualizarRoles '{Convert.ToInt32(lblRlId.Text)}', '{txtRlDescripcion.Text}'";
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
            if (lblRlId.Text != "000" && lblRlId.Text != "")
            {
                sentencia = $"exec spEliminarRoles '{ Convert.ToInt32(lblRlId.Text) }'";
                MessageBox.Show(acceso.EjecutarComando(sentencia));
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol");
            }
        }

        private void BtnRlSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir de la edición?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnRlNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnRlGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnRlEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            nuevo();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void DgRlRol_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicionActual;

            posicionActual = dgRlRol.CurrentRow.Index;
            lblRlId.Text = dgRlRol[0, posicionActual].Value.ToString();
            txtRlDescripcion.Text = dgRlRol[1, posicionActual].Value.ToString();
        }
    }
}
