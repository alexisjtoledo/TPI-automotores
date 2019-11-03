using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Automotores
{
    class MetodosGlobales
    {
        AccesoDatos aDatos = new AccesoDatos();

        public void CargarCombo(string tabla, ComboBox combo)
        {
            DataTable tc = new DataTable();
            tc = aDatos.consultarTabla(tabla);
            combo.DataSource = tc;
            combo.ValueMember = tc.Columns[0].ColumnName;
            combo.DisplayMember = tc.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarTodasTablas(ComboBox combo)
        {
            DataTable t = new DataTable();
            t = aDatos.consultarNombresTablas();
            combo.DataSource = t;
            combo.ValueMember = t.Columns[0].ColumnName;
            combo.DisplayMember = t.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarTodasColumnas(string tabla, ComboBox combo)
        {
            DataTable t = new DataTable();
            t = aDatos.consultarNombresColumnas(tabla);
            combo.DataSource = t;
            combo.ValueMember = t.Columns[0].ColumnName;
            combo.DisplayMember = t.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string obtenerTipoDato(string nTab, string nCol)
        {
            DataTable t = new DataTable();
            string tipoDato;
            t = aDatos.consultarTipoDato(nTab, nCol);
            tipoDato = t.Columns[0].ColumnName;
            return tipoDato;
        }
    }
}
