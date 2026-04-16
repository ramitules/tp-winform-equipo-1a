using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_1A
{
  internal class Articulo
  {
    public int ID { get; set; }

    private string codArticulo;
    public string CodArticulo
    {
      set
      {
        if (value.Length < 50)
        {
          codArticulo = value;
        }
      }
      get { return codArticulo; }
    }

    private string nombre;
    public string Nombre
    {
      set
      {
        if (value.Length < 50)
        {
          nombre = value;
        }
      }
      get { return nombre; }
    }
    
  }
}
