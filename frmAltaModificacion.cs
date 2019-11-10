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
    }
}
