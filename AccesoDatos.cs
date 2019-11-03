using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Automotores
{
    class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dr;
        DataTable dt;

        public SqlDataReader pDr
        {
            get { return dr; }
            set { dr = value; }
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection();
            this.comando = new SqlCommand();
            this.dr = null;
            this.dt = new DataTable();
        }
        public void conectar()
        {
            this.conexion.ConnectionString = @"Data Source=ALEXIS-PC;Initial Catalog=Automotores;Integrated Security=True";
            this.conexion.Open();
            this.comando.Connection = conexion;
            this.comando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            this.conexion.Close();
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            dt = new DataTable();
            this.conectar();
            this.comando.CommandText = "SELECT * FROM " + nombreTabla;
            dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }

        public DataTable consultar(string query)
        {
            DataTable dt = new DataTable();
            this.conectar();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = query;
            this.dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }

        public DataTable consultarNombresTablas()
        {
            DataTable dt = new DataTable();
            this.conectar();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "SELECT TABLE_NAME, REPLACE(TABLE_NAME, '_', ' ') FROM INFORMATION_SCHEMA.TABLES";
            dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }

        public DataTable consultarNombresColumnas(string nombreTabla)
        {
            DataTable dt = new DataTable();
            this.conectar();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "SELECT COLUMN_NAME, REPLACE(COLUMN_NAME, '_', ' ') FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + nombreTabla + "'";
            dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }

        public void leerTabla(string nombreTabla)
        {
            this.conectar();
            this.comando.CommandText = "SELECT * FROM " + nombreTabla;
            this.dr = comando.ExecuteReader();
        }
        public void actualizar(string consultaSql)
        {
            this.conectar();
            this.comando.CommandText = consultaSql;
            this.comando.ExecuteNonQuery();
            this.desconectar();
        }
        public DataTable consultarBD(string consultaSQL)
        {
            dt = new DataTable();
            this.conectar();
            this.comando.CommandText = consultaSQL;
            this.dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }
        public void insertDatos(string nombreTabla, string values)
        {
            this.conectar();
            this.comando.CommandText = "INSERT INTO "+ nombreTabla + "VALUES("+ values +")";
            this.comando.ExecuteNonQuery();
            this.desconectar();
        }

        public void deleteDatos(string nombreTabla, string condition)
        {
            this.conectar();
            this.comando.CommandText = "DELETE FROM " + nombreTabla + "WHERE " + condition;
            this.comando.ExecuteNonQuery();
            this.desconectar();
        }

        public void cargarDatagrid(string query, DataGridView dg)
        {
            using (conexion)
            {
                try
                {
                    this.conectar();
                    this.comando.CommandText = query;
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        DataTable t = new DataTable();
                        t.Load(lector);
                        dg.AutoGenerateColumns = true;
                        dg.DataSource = t;
                        dg.Refresh();
                    }
                    this.desconectar();
                }
                catch (SqlException Exception)
                {
                    MessageBox.Show(Exception.ToString());
                }
            }
        }

        public DataTable ejecutarVista(string nombreVista)
        {
            dt = new DataTable();
            this.conectar();
            this.comando.CommandText = "SELECT * FROM "+ nombreVista;
            this.dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }
        public void ejecutarPA(string nombreProcedure)
        {
            this.conectar();
            this.comando.CommandText = "EXEC "+nombreProcedure;
            this.comando.ExecuteNonQuery();
            this.desconectar();
        }
        public DataTable consultarTipoDato(string nTab, string nCol)
        {
            DataTable dt = new DataTable();
            this.conectar();
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "SELECT DATA_TYPE FROM information_schema.columns WHERE TABLE_NAME = '" 
                + nTab 
                + "' AND COLUMN_NAME = '" 
                + nCol + "'";
            this.dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }
    }
}
