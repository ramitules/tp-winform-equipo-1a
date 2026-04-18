using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TPWinForm_equipo_1A
{
    internal class Datos
    {
        string connectionString;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        
        public Datos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["TPWinForm_equipo_1A"].ConnectionString;
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
        }

    }
}
