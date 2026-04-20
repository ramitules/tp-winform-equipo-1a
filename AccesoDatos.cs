using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TPWinForm_equipo_1A
{
    public class AccesoDatos
    {
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
            conexion = new SqlConnection("server=(localdb)\\MSSQLLocalDB;Initial Catalog=CATALOGO_P3_DB;Integrated Security=True");
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
