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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //this.btnProductos.Enabled = true;
            //this.btnClientes.Enabled = true;
            //this.btnVendedores.Enabled = true;
            //this.button5.Enabled = true;
            //this.btnReportes.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCargarBase fcb = new frmCargarBase();
            fcb.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos fps = new frmProductos();
            fps.ShowDialog();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas fp = new frmConsultas();
            fp.ShowDialog();
        }
    }
}
