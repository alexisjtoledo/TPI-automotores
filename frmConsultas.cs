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
            // Se debe ejecutar un procedimiento almacenado
            
            
            // el boton debe desactivarse luego de que se ejecute
            btnCargarInserts.Enabled = false;
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            frmConsulta fb = new frmConsulta();
            fb.ShowDialog();
            this.Close();
        }

        private void BtnVistasCargadas_Click(object sender, EventArgs e)
        {
            frmPrecargadas fp = new frmPrecargadas();
            fp.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
