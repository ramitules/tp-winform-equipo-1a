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

    private string descripcion;
    public string Descripcion
    {
        set
        {
        if (value.Length < 50)
            {
            descripcion = value;
            }
           
        }
        get { return descripcion; }
    }

    private decimal precio;
    public decimal Precio
    {
        set { 
            if (value > 0)
            {
                precio = value;
            }
            else
            {
                precio = 0;
            }
        }
        get { return precio; }
    }

    public Marca Marca;
    public Categoria Categoria;

    public string Imagen { get; set; }

    }
    
}
