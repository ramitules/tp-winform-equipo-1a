using System;
using System.Collections.Generic;
using System.Data.SqlClient; //Libreria para leer la base de datos
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConexionDB;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            //Coneccion a la base de datos
            AccesoDatos Datos = new AccesoDatos(); //Creo la instancia con la cadena de conexion configurada.

            try
            {
                //Establezco la consulta a la base de datos
                Datos.ConsultaDatos("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS Marca, A.Precio, C.Id AS CategoriaId, C.Descripcion AS Categoria, I.ImagenUrl from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo");
                
                //Ejecuto la consulta y guardo el resultado en un lector de datos.
                Datos.LecturaDatos();

                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)Datos.Lector["Id"];
                    aux.CodArticulo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.Precio = (decimal)Datos.Lector["Precio"];

                    aux.Marca = new Marca((int)Datos.Lector["MarcaID"], (string)Datos.Lector["Marca"]);

                    aux.Categoria = new Categoria((int)Datos.Lector["CategoriaID"], (string)Datos.Lector["Categoria"]);

                    aux.Imagen.Add((string)Datos.Lector["ImagenUrl"]);

                    lista.Add(aux);
                }

                return lista; //Devuelve lista de objetos.
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                Datos.CerrarConexion();
            }
        }


        public void agregar(Articulo nuevo)
        {
        }

        public void modificar(Articulo articulo)
        {
        }

        public void eliminar(int id)
        {
        }
    }
}
