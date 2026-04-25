using ConexionDB;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio: ClaveValorNegocio
    {
        public CategoriaNegocio()
        {
            setTabla("CATEGORIAS");
        }
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.ConsultaDatos(querySelectTodo);
                Datos.LecturaDatos();

                while (Datos.Lector.Read())
                {
                    Categoria auxCategoria = new Categoria((int)Datos.Lector["Id"], (string)Datos.Lector["Descripcion"]);
                    lista.Add(auxCategoria);
                }

                return lista;
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
    }
}
