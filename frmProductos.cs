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
    public partial class frmProductos : Form
    {
        MetodosGlobales m = new MetodosGlobales();
        AccesoDatos aDatos = new AccesoDatos();
        int indexRow;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            aDatos.cargarDatagrid("SELECT * FROM Vista_productos", this.dgProductos);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaModificacion formulario = new frmAltaModificacion();
            formulario.Show();
            this.Hide();
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgProductos.Rows[this.indexRow];
            string id_producto = row.Cells[0].Value.ToString();

            frmAltaModificacion fam = new frmAltaModificacion(id_producto);
            fam.ShowDialog();
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgProductos.Rows[this.indexRow];
            string id_producto = row.Cells[0].Value.ToString();

            aDatos.borrarProducto(id_producto);
            aDatos.cargarDatagrid("SELECT * FROM Vista_productos", this.dgProductos);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Saliendo...", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
