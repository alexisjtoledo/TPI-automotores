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
    public partial class frmAltaModificacion : Form
    {

        MetodosGlobales m = new MetodosGlobales();


        public frmAltaModificacion()
        {
            InitializeComponent();
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            m.CargarCombo("Tipos_de_Producto", cboTipoProd);
            m.CargarCombo("Modelos", cboModelo);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            frmProductos prod = new frmProductos();
            prod.Show();
            this.Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            frmProductos prod = new frmProductos();
            prod.Show();
            this.Hide();
        }

        private void FrmAltaModificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
