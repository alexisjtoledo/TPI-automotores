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
        AccesoDatos aDatos = new AccesoDatos();
        MetodosGlobales m = new MetodosGlobales();
        string pr_id;

        public frmAltaModificacion(string id_producto = "")
        {
            InitializeComponent();
            pr_id = id_producto;
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            if (this.tipoFormulario() == "Modificacion")
            {
                aDatos.buscarProducto(pr_id);
                while (aDatos.pDr.Read())
                {
                    if (!aDatos.pDr.IsDBNull(0))
                    {
                        txtId.Text = Convert.ToString(aDatos.pDr.GetInt32(0));
                    }
                    if (!aDatos.pDr.IsDBNull(1))
                    {
                        txtNombreProd.Text = Convert.ToString(aDatos.pDr.GetString(1));
                    }
                    if (!aDatos.pDr.IsDBNull(2))
                    {
                        txtPrecio.Text = Convert.ToString(aDatos.pDr.GetDecimal(2));
                    }
                    if (!aDatos.pDr.IsDBNull(3))
                    {
                        cboTipoProd.SelectedValue = aDatos.pDr.GetInt32(3);
                    }
                    if (!aDatos.pDr.IsDBNull(4))
                    {
                        txtColor.Text = Convert.ToString(aDatos.pDr.GetString(4));
                    }
                    if (!aDatos.pDr.IsDBNull(5))
                    {
                        txtDetalles.Text = Convert.ToString(aDatos.pDr.GetString(5));
                    }
                    if (!aDatos.pDr.IsDBNull(6))
                    {
                        cboModelo.SelectedValue = aDatos.pDr.GetInt32(6);
                    }
                    if (!aDatos.pDr.IsDBNull(7))
                    {
                        txtStockMin.Text = Convert.ToString(aDatos.pDr.GetInt64(7));
                    }
                    if (!aDatos.pDr.IsDBNull(8))
                    {
                        txtStockAct.Text = Convert.ToString(aDatos.pDr.GetInt64(8));
                    }
                }
            }
            else
            {
                this.cleanFields();
            }

            m.CargarCombo("Tipos_de_Producto", cboTipoProd);
            m.CargarCombo("Modelos", cboModelo);
        }

        private string tipoFormulario()
        {
            if (this.pr_id != "")
            {
                return "Modificacion";
            }

            return "Nuevo";
        }

        private void guardarProducto()
        {
            Producto pr = new Producto();

            pr.pNombre = txtNombreProd.Text;
            pr.pPrecio = Convert.ToDouble(txtPrecio.Text);
            pr.pTipo = Convert.ToInt32(cboTipoProd.SelectedValue);
            pr.pColor = txtColor.Text;
            pr.pDetalle = txtDetalles.Text;
            pr.pModelo = Convert.ToInt32(cboModelo.SelectedValue);
            pr.pStockMin = Convert.ToInt32(txtStockMin.Text);
            pr.pStockActual = Convert.ToInt32(txtStockAct.Text);

            string values = "('" + pr.pNombre + "'" + ","
                                + pr.pPrecio + ","
                                + pr.pTipo + ","
                                + "'" + pr.pColor + "','"
                                + pr.pDetalle + "',"
                                + pr.pModelo + ","
                                + pr.pStockMin + ","
                                + pr.pStockActual + ')';

            aDatos.insertarProducto(values);
            MessageBox.Show(pr.toString() + " INGRESADO CORRECTAMENTE");
            this.cleanFields();
        }

        private void modificarProducto()
        {
            Producto pr = new Producto();

            pr.pNombre = txtNombreProd.Text;
            pr.pPrecio = Convert.ToDouble(txtPrecio.Text);
            pr.pTipo = Convert.ToInt32(cboTipoProd.SelectedValue);
            pr.pColor = txtColor.Text;
            pr.pDetalle = txtDetalles.Text;
            pr.pModelo = Convert.ToInt32(cboModelo.SelectedValue);
            pr.pStockMin = Convert.ToInt32(txtStockMin.Text);
            pr.pStockActual = Convert.ToInt32(txtStockAct.Text);

            string values = "nombre = '" + pr.pNombre + "'," +
                            "precio = " + pr.pPrecio + "," +
                            "id_tipo_producto = " + pr.pTipo + "," +
                            "color = '"+ pr.pColor + "'," +
                            "detalles = '" + pr.pDetalle + "'," +
                            "id_modelo = " + pr.pModelo + "," +
                            "stock_minimo = " + pr.pStockMin + "," +
                            "stock = " + pr.pStockActual;

            aDatos.modificarProducto(values, pr_id);
            MessageBox.Show(pr.toString() + " ACTUALIZADO CORRECTAMENTE");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validateForm())
            {
                // Valido si es un producto nuevo o un producto existente
                if (this.tipoFormulario() == "Nuevo")
                {
                    this.guardarProducto();
                }
                else
                {
                    this.modificarProducto();
                    //this.Close();
                }

                frmProductos prod = new frmProductos();
                prod.Show();
                this.Hide();
            }            
        }

        private bool validateForm()
        {
            if (string.IsNullOrEmpty(txtNombreProd.Text))
            {
                MessageBox.Show("Falta nombre de Producto...");
                txtNombreProd.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe tener precio...");
                txtPrecio.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(txtPrecio.Text);
                }
                catch
                {
                    MessageBox.Show("Coloque sólo números...",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPrecio.Focus();
                    return false;
                }
            }
            if (cboTipoProd.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de producto...");
                cboTipoProd.Focus();
                return false;
            }
            if (cboModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un modelo...");
                cboModelo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStockMin.Text))
            {
                MessageBox.Show("Debe tener stock minimo...");
                txtStockMin.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStockAct.Text))
            {
                MessageBox.Show("Debe tener stock actual...");
                txtStockAct.Focus();
                return false;
            }

            return true;
        }

        private void cleanFields()
        {
            txtNombreProd.Clear();   
            txtPrecio.Clear();
            cboTipoProd.SelectedIndex = -1;
            txtColor.Clear();
            txtDetalles.Clear();
            cboModelo.SelectedIndex = -1;
            txtStockMin.Clear();
            txtStockAct.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            frmProductos prod = new frmProductos();
            prod.Show();
            this.Hide();
        }

        private void FrmAltaModificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
