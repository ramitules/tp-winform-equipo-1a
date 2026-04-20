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

        /*      conexion.ConnectionString = "Server=192.168.0.17,1433;Database=CATALOGO_P3_DB;User Id=sa;Password=Siddharthasanman!;TrustServerCertificate=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS Marca, A.Precio, C.Id AS CategoriaId, C.Descripcion AS Categoria, I.ImagenUrl from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo";
                comando.Connection = conexion;
        
         */
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

        public void CerrarConexion()
        {
            //Hay que cerrar el lector y la conexion.
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
