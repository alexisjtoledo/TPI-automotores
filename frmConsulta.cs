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
    public partial class frmConsulta : Form
    {
        // Inicializo el Acceso a Datos
        AccesoDatos aDatos = new AccesoDatos();
        // Inicializo los Métodos Globales
        MetodosGlobales metodos = new MetodosGlobales();
        // Variable para almacernar la tabla en la que estoy.
        string nTab;
        // Variable para almacenar la columna en la que estoy.
        string nCol;
        // Variable para almecenar la query.
        string query;
        // Variables para el filtro Between.
        string desde;
        string hasta;
        // Variable para el filtro comparador.
        string comparador;
        
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // Deshabilito todos los filtros para arrancar
            // Habilitar(false);
            // Cargo Combo Tablas
            metodos.CargarTodasTablas(cboTabla);
            // Actualizo las variables tabla/Columna
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            nCol = cboColumna.GetItemText(this.cboColumna.SelectedValue);
            // Cargo Combo Columnas
            metodos.CargarTodasColumnas(nTab, cboColumna);
            // Inicializo el programa con la primer tabla cargada por defecto
            aDatos.cargarDatagrid("SELECT * FROM " + nTab, dgvVisor);
        }

        private void Habilitar(bool x)
        {
            this.txtContiene.Enabled = x;
            this.txtValor.Enabled = x;
            this.rbtIgual.Enabled = x;
            this.rbtMayor.Enabled = x;
            this.rbtMenor.Enabled = x;
            this.dtpInicio.Enabled = x;
            this.dtpFin.Enabled = x;
        }

        private void CboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Evento cuando selecciono otra tabla
        private void CboTabla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Actualizo las variables tabla/Columna
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            nCol = cboColumna.GetItemText(this.cboColumna.SelectedValue);
            // Actualizo el combo de columnas
            metodos.CargarTodasColumnas(nTab, cboColumna);
            // Actualizo el visor con la info de la tabla
            aDatos.cargarDatagrid("SELECT * FROM " + nTab, dgvVisor);
            // Dejo la primer columna seleccionada por defecto
            cboColumna.SelectedIndex = 0;
        }

        // Evento cuando selecciono otra columna
        private void CboColumna_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Actualizo las variables tabla/Columna
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            nCol = cboColumna.GetItemText(this.cboColumna.SelectedValue);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultas fcc = new frmConsultas();
            fcc.ShowDialog();
        }

        // FILTRO LIKE
        private void TxtContiene_TextChanged(object sender, EventArgs e)
        {
            this.query = "SELECT * FROM " +
                            nTab +
                            " WHERE " + nCol + 
                            " LIKE '%" + txtContiene.Text + "%'";
        }

        // FILTROS COMPARADORES

        private void crearQueryComparador()
        {
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            nCol = cboColumna.GetItemText(this.cboColumna.SelectedValue);
            if (rbtIgual.Checked)
            {
                comparador = "=";
            }
            else if (rbtMayor.Checked)
            {
                comparador = ">";
            }
            else if (rbtMenor.Checked)
            {
                comparador = "<";
            }
            this.query = "SELECT * FROM " +
                            nTab +
                            " WHERE " + nCol + " " +
                            comparador + " " + txtValor.Text;
        }
        private void RbtMayor_CheckedChanged(object sender, EventArgs e)
        {
            crearQueryComparador();
        }

        private void RbtIgual_CheckedChanged(object sender, EventArgs e)
        {
            crearQueryComparador();
        }

        private void RbtMenor_CheckedChanged(object sender, EventArgs e)
        {
            crearQueryComparador();
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            crearQueryComparador();
        }

        //FILTRO BETWEEN
        private void DtpInicio_ValueChanged(object sender, EventArgs e)
        {
            
            this.desde = String.Format("{0:MM/dd/yyyy}", dtpInicio.Value);
            this.query = "SELECT * FROM " +
                            nTab +
                            " WHERE " + nCol + 
                            " BETWEEN '" + this.desde + 
                            "' AND '" + this.hasta + "'";
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            this.hasta = String.Format("{0:MM/dd/yyyy}", dtpInicio.Value);
            this.query = "SELECT * FROM " +
                            nTab +
                            " WHERE " + nCol +
                            " BETWEEN '" + this.desde +
                            "' AND '" + this.hasta + "'";
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            aDatos.cargarDatagrid(this.query, dgvVisor);
        }

        
    }
}
