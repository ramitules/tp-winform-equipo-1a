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

                    aux.Marca = new Marca((int)Datos.Lector["MarcaId"], (string)Datos.Lector["Marca"]);

                    aux.Categoria = new Categoria((int)Datos.Lector["CategoriaId"], (string)Datos.Lector["Categoria"]);

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
            AccesoDatos datos = new AccesoDatos();

            // 1° Agrego el articulo a la base de datos.

            try
            {
                string consulta = $"INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('{nuevo.CodArticulo}', '{nuevo.Nombre}', '{nuevo.Descripcion}', {nuevo.Marca.Id}, {nuevo.Categoria.Id}, {nuevo.Precio})";

                datos.ConsultaDatos(consulta);
                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

            // 2° Consulto por el el ID del articulo agregago anteriormente.

            try
            {
                string consulta = "";
                datos.ConsultaDatos(consulta);
                datos.EjecutarAccion();

                int id = 0;
                id = (int)datos.Lector["Id"];

                //A completar

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

            // 3° Agrego las imagenes usando el Id del articulo.

            try
            {

                // A completar
                string consulta = "";

                datos.ConsultaDatos(consulta);
                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
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
                string consulta = "UPDATE ARTICULOS SET Codigo = '@Codigo', Nombre = '@Nombre', Descripcion = '@Descripcion', IdMarca = '@IdMarca', IdCategoria = '@IdCategoria', Precio = '@Precio' WHERE Id = '@Id'";
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
                throw new Exception("Error en funcion modificar en ArticuloNegocio: " + ex.Message);
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
                string consulta = "DELETE FROM ARTICULOS WHERE Id = '@Id'";
                datos.ConsultaDatos(consulta);
                datos.SetParametro("@Id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en funcion eliminar en ArticuloNegocio: " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
