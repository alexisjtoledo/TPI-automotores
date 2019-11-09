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
            this.conexion.ConnectionString = @"Data Source=DESKTOP-2UN2K3I\MYSQL17;Initial Catalog=Automotores;Integrated Security=True";
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
            dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }
        public void insertDatos(string nombreTabla, string values)
        {
            this.conectar();
            this.comando.CommandText = "INSERT INTO " + nombreTabla + "VALUES(" + values + ")";
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
            this.comando.CommandText = "SELECT * FROM " + nombreVista;
            dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }
        public void ejecutarPA(string nombreProcedure)
        {
            this.conectar();
            this.comando.CommandText = "EXEC " + nombreProcedure;
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
            dt.Load(comando.ExecuteReader());
            this.desconectar();
            return dt;
        }

        public void cargarVistas()
        {
            this.conectar();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_1 AS SELECT p.nombre+''+p.apellido AS 'Empleado', SUM(df.precio_unitario * df.cantidad) AS 'Cantidad Total Vendida' FROM Facturas f JOIN Detalles_de_Factura df ON df.num_factura = f.num_factura JOIN Empleados em ON em.id_empleado = f.id_empleado JOIN Personas p ON p.id_persona = em.id_persona WHERE em.id_cargo_empleado IN (SELECT id_cargo_empleado FROM Cargos_de_Empleado WHERE nombre != 'Gerente' AND nombre != 'Distribuidor') AND YEAR(f.fecha_factura) = YEAR(GETDATE()) GROUP BY p.nombre+''+p.apellido;";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_2 AS SELECT p.nombre+''+p.apellido AS 'Nombre Empleado', SUM(df.precio_unitario * df.cantidad) AS 'Total Vendido' FROM Facturas f JOIN Detalles_de_Factura df ON df.num_factura = f.num_factura JOIN Empleados em ON em.id_empleado = f.id_empleado JOIN Personas p ON p.id_persona = em.id_persona WHERE DATEDIFF(YEAR, p.fecha_nac, GETDATE()) > 25 AND YEAR(f.fecha_factura) = YEAR(GETDATE()) GROUP BY p.nombre+''+p.apellido HAVING AVG(df.precio_unitario * df.cantidad) > (SELECT AVG(df1.precio_unitario * df1.cantidad) FROM Detalles_de_Factura df1 JOIN Facturas f1 ON f1.num_factura = df1.num_factura WHERE YEAR(f1.fecha_factura) = YEAR(GETDATE()) - 1);";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_3 AS SELECT id_producto AS 'Codigo', nombre AS 'Nombre Producto', precio AS 'Precio' FROM Productos WHERE precio BETWEEN 10000 AND 50000 AND id_producto NOT IN (SELECT pr.id_producto FROM Productos pr JOIN Detalles_de_Factura df ON df.id_producto = pr.id_producto JOIN Facturas f ON f.num_factura = df.num_factura WHERE YEAR(f.fecha_factura) = YEAR(GETDATE()));";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_4 AS SELECT f.num_factura AS 'Numero Factura', f.fecha_factura AS 'Fecha Factura', cl.id_cliente AS 'Codigo Cliente', per.nombre+' '+per.apellido AS 'Nombre Cliente' FROM Facturas f JOIN Clientes cl ON cl.id_cliente = f.id_cliente JOIN Personas per ON per.id_persona = cl.id_persona WHERE MONTH(f.fecha_factura) = 5 AND cl.id_cliente IN (SELECT cl1.id_cliente FROM Clientes cl1 JOIN Personas p ON p.id_persona = cl1.id_persona JOIN Generos g ON g.id_genero = p.id_genero WHERE g.nombre = 'Femenino')";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_5 AS SELECT YEAR(f.fecha_factura) as 'Año', MONTH(f.fecha_factura) as 'Mes', ma.nombre AS 'Marca', SUM(df.cantidad) AS 'Total Autos Vendidos' FROM Marcas ma JOIN Modelos mo ON ma.id_marca=mo.id_marca JOIN Productos p ON mo.id_modelo = p.id_modelo JOIN Detalles_de_Factura df ON df.id_producto = p.id_producto JOIN Facturas f ON df.num_factura = f.num_factura WHERE YEAR(f.fecha_factura) > YEAR(GETDATE())-2 GROUP BY YEAR(f.fecha_factura), MONTH(f.fecha_factura), ma.nombre;";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_6 AS SELECT e.id_empleado AS 'ID Empleado', p.apellido+' '+p.nombre AS 'Nombre Completo', SUM(df.precio_unitario*df.cantidad) AS 'Total Vendido' FROM Empleados e, Personas p, Detalles_de_Factura df, Facturas f WHERE YEAR(f.fecha_factura) = YEAR(GETDATE()) AND DATEDIFF(MONTH, f.fecha_factura, GETDATE()) <= 6 AND e.id_persona = p.id_persona AND f.id_empleado = e.id_empleado AND df.num_factura = f.num_factura GROUP BY e.id_empleado, p.apellido+' '+p.nombre HAVING SUM(df.precio_unitario * df.cantidad) < (SELECT AVG(df1.precio_unitario * df1.cantidad) FROM Detalles_de_Factura df1, Facturas f1 WHERE YEAR(f1.fecha_factura) = YEAR(GETDATE()) AND DATEDIFF(MONTH, f1.fecha_factura, GETDATE()) <= 6 AND f1.num_factura = df1.num_factura);";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_7 AS SELECT pr.id_producto AS 'Codigo Producto', mo.nombre AS 'Modelo' FROM Productos pr JOIN Modelos mo ON mo.id_modelo = pr.id_modelo AND pr.id_producto NOT IN (SELECT df.id_producto FROM Detalles_de_Factura df JOIN Facturas f ON f.num_factura = df.num_factura WHERE YEAR(f.fecha_factura) BETWEEN '2015' AND '2017')";
            this.comando.ExecuteNonQuery();
            this.comando.CommandText = "CREATE VIEW Vista_Consulta_8 AS SELECT MONTH(f.fecha_factura) AS 'Mes', p.nombre+' '+p.apellido AS 'Empleado', SUM(df.precio_unitario * df.cantidad) AS 'Total Factura', AVG(df.precio_unitario * df.cantidad) AS 'Promedio Facturado' FROM Facturas f JOIN Detalles_de_Factura df ON df.num_factura = f.num_factura JOIN Empleados e ON e.id_empleado = f.id_empleado JOIN Personas p ON p.id_persona = e.id_persona JOIN Cargos_de_Empleado ce ON e.id_cargo_empleado = ce.id_cargo_empleado WHERE ce.nombre = 'Vendedor' AND DATEDIFF(YEAR, e.fecha_insercion, GETDATE()) > 1 AND YEAR(f.fecha_factura) = '2019' GROUP BY MONTH(f.fecha_factura), p.nombre+' '+p.apellido HAVING AVG(df.precio_unitario * df.cantidad) < (SELECT AVG(df1.precio_unitario * df1.cantidad) FROM Detalles_de_Factura df1 JOIN Facturas f1 ON f1.num_factura = df1.num_factura WHERE YEAR(f1.fecha_factura) = YEAR(GETDATE()) - 1)";
            this.comando.ExecuteNonQuery();
            this.desconectar();
        }
    }
}