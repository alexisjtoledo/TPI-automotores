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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCargarBase fcb = new frmCargarBase();
            fcb.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos fps = new frmProductos();
            fps.Show();
            this.Hide();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas fp = new frmConsultas();
            fp.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Saliendo...", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frs = new frmReportes();
            frs.ShowDialog();
        }
    }
}
