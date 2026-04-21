using ConexionDB;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            //Coneccion a la base de datos
            AccesoDatos Datos = new AccesoDatos(); //Creo la instancia con la cadena de conexion configurada.

            try
            {
                //CORREGIR CONSULTA: Traer solo categorias.
                //Establezco la consulta a la base de datos
                Datos.ConsultaDatos("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS Marca, A.Precio, C.Id AS CategoriaId, C.Descripcion AS Categoria, I.ImagenUrl from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo");

                //Ejecuto la consulta y guardo el resultado en un lector de datos.
                Datos.LecturaDatos();

                while (Datos.Lector.Read())
                {
                    Categoria auxCategoria = new Categoria((int)Datos.Lector["CategoriaId"], (string)Datos.Lector["Categoria"]);

                    lista.Add(auxCategoria);
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

        public void modificar(Articulo articulo)
        {
        }

        public void eliminar(int id)
        {
        }
    }
}
