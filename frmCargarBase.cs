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
            frmPrincipal form = new frmPrincipal();
            form.Show();
            this.Hide();
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
            this.button1.Enabled = true;
        }

        private void btnCargarStructure_Click(object sender, EventArgs e)
        {
            this.aDatos.ejecutarPA("cargar_estructura");
            MessageBox.Show("Ejecucion con exito");
            btnCargarStructure.Enabled = false;
            btnCargarData.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.aDatos.cargarVistas();
            MessageBox.Show("Ejecucion con exito");
            this.button1.Enabled = false;
        }

        private void frmCargarBase_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmCargarBase_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Su base de datos ya se encuentra cargada correctamente.");
            btnCargarStructure.Enabled = false;
            btnCargarData.Enabled = false;
            button1.Enabled = false;
        }

        private void FrmCargarBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
