using ConexionDB;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio: ClaveValorNegocio
    {
        public MarcaNegocio()
        {
            setTabla("MARCAS");
        }
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.ConsultaDatos(querySelectTodo);
                Datos.LecturaDatos();

                while (Datos.Lector.Read())
                {
                    Marca auxMarca = new Marca((int)Datos.Lector["Id"], (string)Datos.Lector["Descripcion"]);
                    lista.Add(auxMarca);
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
