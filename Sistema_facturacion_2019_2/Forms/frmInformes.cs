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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void BtnFcSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
