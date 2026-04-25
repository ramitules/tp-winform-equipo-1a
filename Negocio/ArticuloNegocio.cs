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
        private string querySelectTodo = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS Marca, A.Precio, C.Id AS CategoriaId, C.Descripcion AS Categoria, ISNULL(I.ImagenUrl, 'NADA') AS ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo";
        private string queryInsertArticulo = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@cod, @name, @desc, @idMarca, @idCateg, @precio)";
        private string querySelectId = "SELECT TOP 1 Id FROM ARTICULOS ORDER BY Id DESC";
        private string queryInsertImg = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imgUrl)";
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            //Coneccion a la base de datos
            AccesoDatos Datos = new AccesoDatos(); //Creo la instancia con la cadena de conexion configurada.

            try
            {
                //Establezco la consulta a la base de datos
                Datos.ConsultaDatos(querySelectTodo);
                
                //Ejecuto la consulta y guardo el resultado en un lector de datos.
                Datos.LecturaDatos();

                int idAnterior = 0;
                while (Datos.Lector.Read())
                {
                    int idActual = (int)Datos.Lector["id"];
                    if (idAnterior != idActual)
                    {
                        Articulo aux = new Articulo();
                        aux.ID = (int)Datos.Lector["Id"];
                        aux.CodArticulo = (string)Datos.Lector["Codigo"];
                        aux.Nombre = (string)Datos.Lector["Nombre"];
                        aux.Descripcion = (string)Datos.Lector["Descripcion"];
                        aux.Precio = (decimal)Datos.Lector["Precio"];

                        aux.Marca = new Marca((int)Datos.Lector["MarcaId"], (string)Datos.Lector["Marca"]);

                        aux.Categoria = new Categoria((int)Datos.Lector["CategoriaId"], (string)Datos.Lector["Categoria"]);

                        aux.Imagen.Add((string)Datos.Lector["ImagenUrl"]);

                        lista.Add(aux);
                        
                        idAnterior = idActual;
                    }
                    else
                    {
                        lista[lista.Count() - 1].Imagen.Add((string)Datos.Lector["ImagenUrl"]);
                    }
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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // 1° Agrego el articulo a la base de datos.
                agregarNuevoArticulo(datos, nuevo);

                // 2° Consulto por el el ID del articulo agregago anteriormente.
                int idArticulo = getUltimoId(datos);

                // 3° Agrego las imagenes usando el Id del articulo.
                foreach (string imgUrl in nuevo.Imagen)
                {
                    agregarImagen(datos, idArticulo, imgUrl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id";
                datos.ConsultaDatos(consulta);
                datos.SetParametro("@Codigo", articulo.CodArticulo);
                datos.SetParametro("@Nombre", articulo.Nombre);
                datos.SetParametro("@Descripcion", articulo.Descripcion);
                datos.SetParametro("@IdMarca", articulo.Marca.Id);
                datos.SetParametro("@IdCategoria", articulo.Categoria.Id);
                datos.SetParametro("@Precio", articulo.Precio);
                datos.SetParametro("@Id", articulo.ID);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar un articulo (ArticuloNegocio.modificar): " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM ARTICULOS WHERE Id = @Id";
                datos.ConsultaDatos(consulta);
                datos.SetParametro("@Id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar un articulo (ArticuloNegocio.eliminar): " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        private void agregarImagen(AccesoDatos datos, int id, string url)
        {
            try
            {
                datos.ConsultaDatos(queryInsertImg);
                datos.SetParametro("@Id", id);
                datos.SetParametro("@Imagen", url);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar nueva imagen (ArticuloNegocio.agregarImagen): " + ex.Message);
            }
        }

        private void agregarNuevoArticulo(AccesoDatos datos, Articulo nuevo)
        {
            try
            {
                datos.ConsultaDatos(queryInsertArticulo);
                datos.SetParametro("@cod", nuevo.CodArticulo);
                datos.SetParametro("@name", nuevo.Nombre);
                datos.SetParametro("@desc", nuevo.Descripcion);
                datos.SetParametro("@idMarca", nuevo.Marca.Id);
                datos.SetParametro("@idCateg", nuevo.Categoria.Id);
                datos.SetParametro("@precio", nuevo.Precio);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar un nuevo articulo (ArticuloNegocio.agregarNuevoArticulo): " + ex.Message);
            }
        }

        private int getUltimoId(AccesoDatos datos)
        {
            try
            {
                datos.ConsultaDatos(querySelectId);
                datos.LecturaDatos();
                datos.Lector.Read();
                return datos.Lector.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID del ultimo articulo agregado (ArticuloNegocio.getUltimoId): " + ex.Message);
            }

        }
    }
}
