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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Focus();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
        }

        private void login()
        {
            if (txtUsuario.Text == "admin" && txtContrasena.Text == "admin")
            {
                frmPrincipal form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else if (txtUsuario.Text != "admin")
            {
                MessageBox.Show("El usuario ingresado no es correcto.");
                txtUsuario.Focus();
            }
            else if (txtContrasena.Text != "admin")
            {
                MessageBox.Show("La contraseña ingresada no es correcta.");
                txtContrasena.Focus();
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese su usuario y su contraseña.");
                txtUsuario.Focus();
            }

        }

        private void TxtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData == (int)Keys.Enter)
            {
                this.login();
            }
        }
    }
}
