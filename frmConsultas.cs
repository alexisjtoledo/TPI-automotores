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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnCargarInserts_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            frmConsulta fb = new frmConsulta();
            fb.Show();
            this.Hide();
        }

        private void BtnVistasCargadas_Click(object sender, EventArgs e)
        {
            frmPrecargadas fp = new frmPrecargadas();
            fp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal princ = new frmPrincipal();
            princ.Show();
            this.Hide();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void FrmConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
