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


        public frmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // Deshabilito todos los filtros para arrancar
            Habilitar(false);
            // Cargo Combo Tablas
            metodos.CargarTodasTablas(cboTabla);
            // Actualizo la variable tablas
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            // Cargo Combo Columnas
            metodos.CargarTodasColumnas(nTab, cboColumna);
            // Por defecto selecciono todas las columnas
            nCol = "*";
            // Inicializo el programa con la primer tabla cargada por defecto
            aDatos.cargarDatagrid(nTab, nCol, dgvVisor);
            // Por defecto el combo columnas está vacío
            cboColumna.SelectedIndex = -1;
        }

        private void Habilitar(bool x)
        {
            this.txtContiene.Enabled = x;
            this.txtValor.Enabled = x;
            this.rbtAscendente.Enabled = x;
            this.rbtDescendente.Enabled = x;
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
            // Actualizo mi nueva selección
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            // Actualizo para que muestre todas las columnas hasta que seleccione una
            nCol = "*";
            // Actualizo el combo de columnas
            metodos.CargarTodasColumnas(nTab, cboColumna);
            // Actualizo el visor con la info de la tabla
            aDatos.cargarDatagrid(nTab, nCol, dgvVisor);
            // Dejo el combo vacío por defecto
            cboColumna.SelectedIndex = -1;
        }

        // Evento cuando selecciono otra columna
        private void CboColumna_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Actualizo mi nueva selección
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            // Actualizo la variable
            nCol = cboColumna.GetItemText(this.cboColumna.SelectedValue);
            // Recargo el Visor con la nueva columna
            aDatos.cargarDatagrid(nTab, nCol, dgvVisor);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
