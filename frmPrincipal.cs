using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotores
{
    public partial class frmPrincipal : Form
    {

        AccesoDatos aDatos = new AccesoDatos();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            frmConsultas fp = new frmConsultas();
            fp.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.btnProductos.Enabled = false;
            this.btnClientes.Enabled = false;
            this.btnVendedores.Enabled = false;
            this.button5.Enabled = true;
            this.btnReportes.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCargarBase fcb = new frmCargarBase();
            fcb.ShowDialog();
        }
    }
}
