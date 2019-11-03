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
    public partial class frmPrecargadas : Form
    {
        public frmPrecargadas()
        {
            InitializeComponent();
        }

        //  Eventos On Click
        private void BtnConsulta1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta2_Click(object sender, EventArgs e)
        {

        }
        private void BtnConsulta3_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta4_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta5_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta6_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta7_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsulta8_Click(object sender, EventArgs e)
        {

        }

        // Eventos On Hover
        private void BtnConsulta1_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 1: \nSumatoria que vendió cada empleado este año, pero solo aquellos empleados que no tengan como cargo\nGerente ni Distribuidor";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;

        }
        private void BtnConsulta2_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 2: Texto consulta 2.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta3_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 3: Texto consulta 3.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta4_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 4: Texto consulta 4.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta5_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 5: Texto consulta 5.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta6_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 6: Texto consulta 6.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta7_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 7: Texto consulta 7.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta8_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 8: Texto consulta 8.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Eventos On Leave
        private void BtnConsulta1_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
        private void BtnConsulta2_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
       
        private void BtnConsulta3_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
        private void BtnConsulta4_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
        private void BtnConsulta5_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
        private void BtnConsulta6_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
        private void BtnConsulta7_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }
        private void BtnConsulta8_MouseLeave(object sender, EventArgs e)
        {
            txtConsulta.Text = "";
        }

    }
}
