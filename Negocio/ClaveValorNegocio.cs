using ConexionDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClaveValorNegocio
    {
        protected string Tabla = "";
        protected string querySelectTodo = "SELECT Id, Descripcion FROM ??";
        protected string queryInsert = "INSERT INTO ?? (Descripcion) VALUES (@descripcion)";
        protected string queryDelete = "DELETE FROM ?? WHERE Id = @id";
        protected string queryDeleteDesc = "DELETE FROM ?? WHERE Descripcion = @descripcion";
        protected void setTabla(string Tabla)
        {
            this.Tabla = Tabla;
            querySelectTodo = querySelectTodo.Replace("??", this.Tabla);
            queryInsert = queryInsert.Replace("??", this.Tabla);
            queryDelete = queryDelete.Replace("??", this.Tabla);
            queryDeleteDesc = queryDeleteDesc.Replace("??", this.Tabla);
        }

        public void agregar(string descripcion)
        {
            if (queryInsert.Contains("??"))
                return;

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.ConsultaDatos(queryInsert);
                datos.SetParametro("@descripcion", descripcion);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar un registro en la tabla {Tabla}: " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            if (queryDelete.Contains("??"))
                return;

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.ConsultaDatos(queryDelete);
                datos.SetParametro("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar un registro en la tabla {Tabla}: " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void eliminar(string descripcion)
        {
            if (queryDeleteDesc.Contains("??"))
                return;

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.ConsultaDatos(queryDeleteDesc);
                datos.SetParametro("@descripcion", descripcion);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar un registro en la tabla {Tabla}: " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
