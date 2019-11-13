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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            vistaReporte1 frmReporte1 = new vistaReporte1();
            frmReporte1.ShowDialog();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            vistaReporte2 frmReporte2 = new vistaReporte2();
            frmReporte2.ShowDialog();
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            vistaReporte3 frmReporte3 = new vistaReporte3();
            frmReporte3.ShowDialog();
        }

        private void frmReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
