using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace ConexionDB
{
    public class AccesoDatos
    {
        private Dictionary<string, string> variables = VariablesEntorno.CargarVariables();
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //Constructor 
        public AccesoDatos()
        {
            string server = variables["DB_HOST"];
            string puerto = variables["DB_PORT"];
            string db = variables["DB_NAME"];
            string user = variables["DB_USER"];
            string contra = variables["DB_PASSWORD"];

            // Añadir puerto a la cadena de servidor si existe
            string serverCompleto = string.IsNullOrEmpty(puerto) ? server : server + "," + puerto;

            conexion = new SqlConnection($"Server={serverCompleto};Database={db};User Id={user};Password={contra};TrustServerCertificate=true;");
            comando = new SqlCommand();
        }

        public void ConsultaDatos(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void LecturaDatos()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void SetParametro(string param, object valor)
        {
            comando.Parameters.AddWithValue(param, valor);
        }

        public void CerrarConexion()
        {
            //Hay que cerrar el lector y la conexion.
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
        public int EjecutarEscalar()
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
