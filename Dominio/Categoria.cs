using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; }
        
        public string Descripcion { get; }

        public Categoria(int id, string descripcion)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id", id, "Se esta intentando asignar un ID menor o igual a cero en un objeto Categoria");
            }
            if (descripcion.Length >= 50)
            {
                throw new ArgumentOutOfRangeException("nombre", descripcion, "Se esta intentando asignar una descripcion demasiado larga en un objeto Categoria");
            }
            Id = id;
            Descripcion = descripcion;
        }

        //Sobreescribo el metodo ToString para que me muestre la marca en vez del tipo de dato.
        public override string ToString()
        {
            return Descripcion;
        }
}
}
