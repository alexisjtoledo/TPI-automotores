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
    public partial class frmProductos : Form
    {

        MetodosGlobales m = new MetodosGlobales();
        AccesoDatos aDatos = new AccesoDatos();

        List<string> lstSql = new List<string>();

        string nombre;
        string marca;
        string modelo;
        string precio;
        string tipoProd;
        string sql;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            aDatos.cargarDatagrid("SELECT * FROM Vista_productos", this.dgProductos);
            m.CargarCombo("Marcas", cboFiltroMarca);
            m.CargarCombo("Modelos", cboFiltroModelo);
            m.CargarCombo("Tipos_de_Producto", cmbFiltroTipoProducto);
            cboFiltroMarca.SelectedIndex = -1;
            cboFiltroModelo.SelectedIndex = -1;
            cmbFiltroTipoProducto.SelectedIndex = -1;

        }
        public bool textoInt(TextBox txt)
        {
            try
            {
                Int32.Parse(txt.Text);
                return true;
            }
            catch
            {
                txt.Focus();
                MessageBox.Show("Esta caja de texto solo acepta numeros");
                return false;
            }
        }
        private void consultaFiltro()
        {
            lstSql.Clear();
            if (txtFiltroNombre.Text != "")
            {
                this.nombre = "p.nombre LIKE '%" + txtFiltroNombre.Text + "%'";
                lstSql.Add(nombre);
            }
            if (cboFiltroMarca.SelectedIndex != -1)
            {
                this.marca = "ma.id_marca = " + cboFiltroMarca.SelectedValue;
                lstSql.Add(marca);
            }
            if (cboFiltroModelo.SelectedIndex != -1)
            {
                this.modelo = "mo.id_modelo = " + cboFiltroModelo.SelectedValue;
                lstSql.Add(modelo);
            }
            if ((rbIgualQue.Checked || rbMayorQue.Checked || rbMenorQue.Checked) && textoInt(txtFiltroPrecio))
            {
                if (rbMayorQue.Checked)
                {
                    this.precio = "p.precio > " + txtFiltroPrecio.Text;
                    lstSql.Add(precio);
                }
                if (rbIgualQue.Checked)
                {
                    this.precio = "p.precio = " + txtFiltroPrecio.Text;
                    lstSql.Add(precio);
                }
                if (rbMenorQue.Checked)
                {
                    this.precio = "p.precio < " + txtFiltroPrecio.Text;
                    lstSql.Add(precio);
                }
            }
            if (cmbFiltroTipoProducto.SelectedIndex != -1)
            {
                this.tipoProd = "tdp.id_tipo_producto = " + cmbFiltroTipoProducto.SelectedValue;
                lstSql.Add(tipoProd);
            }
            for (int i = 1; i <= lstSql.Count; i++)
            {
                if (i == 1)
                    sql += " WHERE ";
                if (i > 1)
                    sql += " AND ";
                sql += lstSql[i - 1];

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaModificacion formulario = new frmAltaModificacion();
            formulario.Show();
            this.Hide();
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            frmAltaModificacion formulario = new frmAltaModificacion();
            formulario.Show();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Messagebox!
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Saliendo...", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                    this.Controls[i].Text = "";
                if (this.Controls[i] is CheckBox)
                    ((CheckBox)this.Controls[i]).Checked = false;
                if (this.Controls[i] is RadioButton)
                    ((RadioButton)this.Controls[i]).Checked = false;
                if (this.Controls[i] is DateTimePicker)
                    ((DateTimePicker)this.Controls[i]).Value = DateTime.Today;
                if (this.Controls[i] is ComboBox)
                    ((ComboBox)this.Controls[i]).SelectedIndex = -1;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            sql = "select p.id_producto, p.nombre, p.precio, tdp.nombre as 'tipo de producto', p.color, p.detalles,ma.nombre as 'marca',mo.nombre as 'modelo', p.stock from Productos p join Modelos mo on mo.id_modelo = p.id_modelo join Marcas ma on ma.id_marca = mo.id_marca join Tipos_de_Producto tdp on tdp.id_tipo_producto = p.id_tipo_producto";
            consultaFiltro();
            aDatos.cargarDatagrid(sql, dgProductos);
        }
    }
}
