using ConexionDB;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            //Coneccion a la base de datos
            AccesoDatos Datos = new AccesoDatos(); //Creo la instancia con la cadena de conexion configurada.

            try
            {
                //CORREGIR CONSULTA: Traer solo marcas.
                //Establezco la consulta a la base de datos
                Datos.ConsultaDatos("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS Marca, A.Precio, C.Id AS CategoriaId, C.Descripcion AS Categoria, I.ImagenUrl from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo");

                //Ejecuto la consulta y guardo el resultado en un lector de datos.
                Datos.LecturaDatos();

                while (Datos.Lector.Read())
                {
                    Marca auxMarca = new Marca((int)Datos.Lector["MarcaId"], (string)Datos.Lector["Marca"]);

                    lista.Add(auxMarca);
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
                datos.ConsultaDatos(""); //Falta la consulta para agregar un nuevo articulo a la base de datos.
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
        }

        public void eliminar(int id)
        {
        }
    }
}
