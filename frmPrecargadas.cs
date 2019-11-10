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
        // Inicializo el Acceso a Datos
        AccesoDatos aDatos = new AccesoDatos();
        public frmPrecargadas()
        {
            InitializeComponent();
        }

        //  Eventos On Click
        private void BtnConsulta1_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_1");
        }

        private void BtnConsulta2_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_2");
        }
        private void BtnConsulta3_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_3");
        }

        private void BtnConsulta4_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_4");
        }

        private void BtnConsulta5_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_5");
        }

        private void BtnConsulta6_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_6");
        }

        private void BtnConsulta7_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_7");
        }

        private void BtnConsulta8_Click(object sender, EventArgs e)
        {
            dgRespuesta.DataSource = aDatos.ejecutarVista("Vista_Consulta_8");
        }

        // Eventos On Hover
        private void BtnConsulta1_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 1: \nSumatoria total que vendió cada empleado este año, pero solo aquellos empleados que no tengan\n como cargo Gerente ni Distribuidor.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;

        }
        private void BtnConsulta2_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 2: \nVenta total que hizo cada empleado, pero solo aquellos que en donde el promedio total de sus ventas\n de este año supere al promedio de ventas del año pasado. Como condición, \nlos empleados deben tener más de 25 años.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta3_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 3: \nEmitir un listado de los productos que no fueron vendidos este año. \nEn ese listado solo incluir aquellos cuyo precio del artículo oscile entre 10000 y 50000.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta4_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 4: \nListe los datos de las facturas que solo se efectuaron en mayo y en donde el cliente sea mujer.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta5_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 5: \nCantidad de autos vendidos por marca y por mes de los últimos 2 años.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta6_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 6: \nLista de los empleados que en los últimos seis meses vendieron \nun monto total menor al promedio del acumulado en esos 6 meses.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta7_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 7: \nModelos de automoviles que no fueron vendidos entre los años 2015 y 2017. \nLuego ordenar por codigo en forma descendiente y modelo de forma ascendente.";
            txtConsulta.SelectAll();
            txtConsulta.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void BtnConsulta8_MouseHover(object sender, EventArgs e)
        {
            txtConsulta.Text = "CONSULTA 8: \nListar todos empleados con sus Totales de facturación mensual(2019) y Promedios de facturación mensual(2019), de solo aquellos en donde su promedio de facturacion sea menor al del año pasado y que todos aquellos empleados tengan cargo de vendedor y que tengan más de un año de antiguedad en la empresa.";
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmConsultas menu = new frmConsultas();
            menu.Show();
            this.Hide();
        }

        private void FrmPrecargadas_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrecargadas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Saliendo...", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
