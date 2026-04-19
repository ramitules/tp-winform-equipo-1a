using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_1A
{
    internal class Negocio
    {
        List<Articulo> lista = new List<Articulo>();
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public List<Articulo> listar()
        {
            try
            {
                conexion.ConnectionString = "Server=192.168.0.17,1433;Database=CATALOGO_P3_DB;User Id=sa;Password=Siddharthasanman!;TrustServerCertificate=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS Marca, A.Precio, C.Id AS CategoriaId, C.Descripcion AS Categoria, I.ImagenUrl from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)lector["Id"];
                    aux.CodArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["MarcaID"];
                    aux.Marca.Nombre = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["CategoriaID"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Imagen.Add((string)lector["ImagenUrl"]);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
