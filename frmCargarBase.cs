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
    public partial class frmCargarBase : Form
    {
        AccesoDatos aDatos = new AccesoDatos();
        public frmCargarBase()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Close();
        }

        private void btnDeleteBase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar la base: Automotores?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // Funcion Borrar Base
                //Close();
            }
        }

        private void btnCargarData_Click(object sender, EventArgs e)
        {
            this.aDatos.ejecutarPA("cargar_datos");
            MessageBox.Show("Ejecucion con exito");
            btnCargarData.Enabled = false;
        }

        private void btnCargarStructure_Click(object sender, EventArgs e)
        {
            this.aDatos.ejecutarPA("cargar_estructura");
            MessageBox.Show("Ejecucion con exito");
            btnCargarStructure.Enabled = false;
        }
    }
}
