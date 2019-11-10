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
            




        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
