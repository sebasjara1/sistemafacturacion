using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_facturacion_2019_2
{
    class Acceso_datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd()
        {
            try
            {
                conexion = new SqlConnection("Data Source=DESKTOP-3OMK22L\\SQLEXPRESS;Initial Catalog =DBFACTURACION; Integrated Security = True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("falló conexión " + ex.ToString());
            }
        }

        public void CerrarBd()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló cerrar conexión"+ ex.ToString());
            }
        }

        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string empleado = "";
                string sentencia = $"select e.strNombre, e.IdRolEmpleado from tblseguridad s inner join tblempleados e on s.IdEmpleado = e.IdEmpleado where s.StrUsuario = '{StrUsuario}' and s.StrClave = '{StrClave}'";

                AbrirBd();

                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; // CommandType.StoreProcedure -> procedimientos almacenados
                cmd.CommandTimeout = 10; //Tiempo máximo para responder.
                LectorDatos = cmd.ExecuteReader(); // Ejecutar sentencia

                while (LectorDatos.Read())
                {
                    empleado = Convert.ToString(LectorDatos.GetValue(0));
                }

                if (LectorDatos != null)
                {
                    LectorDatos.Close();
                }

                return empleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falla lectura: " + ex.ToString());
                return "";                
            }
        }

        public string EjecutarComando(string sentencia)
        {
            string salida;

            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Acción compleatada con éxito";
                }
                else
                {
                    salida = "Error al ejecutar la solicitud";
                }
            }
            catch (Exception ex)
            {
                salida = "Falló inserción: " + ex.ToString();
            }

            return salida;
        }

        public DataTable Cargartabla(string tabla, string condicion)
        {
            try
            {
                AbrirBd();
                string sql = "select * from " + tabla + " " + condicion;
                da = new SqlDataAdapter(sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.ToString());
                return null;
            }
        }

        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la operación: " + ex.ToString());
                return null;
            }
        }
    }
}
