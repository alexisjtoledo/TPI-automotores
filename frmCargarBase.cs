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
    }
}
