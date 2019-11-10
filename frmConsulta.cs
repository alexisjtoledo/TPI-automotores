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
        // Variable tipo dato
        string tipoDato;
        // Banderas
        bool comp = false;
        bool bet = false;
        bool cont = false;


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
            this.btnConsultar.Enabled = x;
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
            Habilitar(false);
        }

        // Evento cuando selecciono otra columna
        private void CboColumna_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Actualizo las variables tabla/Columna
            nTab = cboTabla.GetItemText(this.cboTabla.SelectedValue);
            nCol = cboColumna.GetItemText(this.cboColumna.SelectedValue);
            // Chequeo el tipo de dato de la columna
            tipoDato = metodos.obtenerTipoDato(nTab, nCol);
            // Habilito los filtros según el tipo de celda
            if (tipoDato == "int" || tipoDato == "bigint" || tipoDato == "decimal" || tipoDato == "integer")
            {
                // Habilito los campos correspondientes
                this.txtValor.Enabled = true;
                this.rbtIgual.Enabled = true;
                this.rbtMayor.Enabled = true;
                this.rbtMenor.Enabled = true;
                this.btnConsultar.Enabled = true;
                // Selecciono por default el =
                this.rbtIgual.Checked = true;
                this.rbtMayor.Checked = false;
                this.rbtMenor.Checked = false;
                // Bloqueo todo lo demás
                this.txtContiene.Enabled = false;
                this.dtpInicio.Enabled = false;
                this.dtpFin.Enabled = false;
                // Limpio todos los demás campos
                this.txtContiene.Clear();
                this.dtpInicio.Value = DateTime.Today;
                this.dtpFin.Value = DateTime.Today;
            }
            else if (tipoDato == "varchar" || tipoDato == "text")
            {
                // Habilito los campos correspondientes
                this.txtContiene.Enabled = true;
                this.btnConsultar.Enabled = true;
                // Deshabilito los demás
                this.dtpInicio.Enabled = false;
                this.dtpFin.Enabled = false;
                this.txtValor.Enabled = false;
                this.rbtIgual.Enabled = false;
                this.rbtMayor.Enabled = false;
                this.rbtMenor.Enabled = false;
                // Limpio Checkboxes
                this.rbtIgual.Checked = false;
                this.rbtMayor.Checked = false;
                this.rbtMenor.Checked = false;
                // Limpio todos los demás campos
                this.dtpInicio.Value = DateTime.Today;
                this.dtpFin.Value = DateTime.Today;
                this.txtValor.Clear();
            }
            else if (tipoDato == "datetime")
            {
                // Habilito los campos correspondientes
                this.dtpInicio.Enabled = true;
                this.dtpFin.Enabled = true;
                this.btnConsultar.Enabled = true;
                // Deshabilito los demás
                this.txtContiene.Enabled = false;
                this.txtValor.Enabled = false;
                this.rbtIgual.Enabled = false;
                this.rbtMayor.Enabled = false;
                this.rbtMenor.Enabled = false;
                // Limpio Checkboxes
                this.rbtIgual.Checked = false;
                this.rbtMayor.Checked = false;
                this.rbtMenor.Checked = false;
                // Limpio los demás campos
                this.txtContiene.Clear();
                this.txtValor.Clear();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmConsultas fcc = new frmConsultas();
            fcc.Show();
            this.Hide();
        }

        // FILTRO LIKE
        private void TxtContiene_TextChanged(object sender, EventArgs e)
        {
            this.query = "SELECT * FROM " +
                      nTab +
                      " WHERE " + nCol +
                      " LIKE '%" + txtContiene.Text + "%'";
            this.comp = false;
            this.bet = false;
            this.cont = true;
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
            this.comp = true;
            this.bet = false;
            this.cont = false;
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
            this.comp = false;
            this.bet = true;
            this.cont = false;
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            this.hasta = String.Format("{0:MM/dd/yyyy}", dtpFin.Value);
            this.query = "SELECT * FROM " +
                            nTab +
                            " WHERE " + nCol +
                            " BETWEEN '" + this.desde +
                            "' AND '" + this.hasta + "'";
            this.comp = false;
            this.bet = true;
            this.cont = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aDatos.cargarDatagrid(this.query, dgvVisor);
            }
            this.comp = false;
            this.bet = false;
            this.cont = false;
        }

        private bool validar()
        {
            if (this.comp == true)
            {
                if (string.IsNullOrEmpty(txtValor.Text))
                {
                    MessageBox.Show("Debe introducir un valor.");
                    txtValor.Focus();
                    return false;
                }
                else
                {
                    try
                    {
                        Int32.Parse(txtValor.Text);
                    }
                    catch
                    {
                        MessageBox.Show("El valor debe ser numérico.");
                        txtValor.Focus();
                        return false;
                    }
                }
                return true;
            }

            if (this.cont == true)
            {
                if (string.IsNullOrEmpty(txtContiene.Text))
                {
                    MessageBox.Show("Para filtrar debe introducir un valor.");
                    txtContiene.Focus();
                    return false;
                }
                return true;
            }

            if (this.bet == true)
            {
                if (dtpFin.Value > DateTime.Today || dtpInicio.Value > DateTime.Today)
                {
                    MessageBox.Show("Las fechas no pueden ser mayores al día de hoy.");
                    dtpInicio.Focus();
                    return false;
                }
                if (dtpFin.Value < dtpInicio.Value)
                {
                    MessageBox.Show("La fecha 'hasta' no puede ser posterior a la fecha 'desde'.");
                    dtpFin.Focus();
                    return false;
                }
                return true;
            }
            return false;
        }

        private void FrmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmConsultas fcc = new frmConsultas();
            fcc.Show();
            this.Hide();
        }
    }
}