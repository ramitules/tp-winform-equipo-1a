using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; }
        public Marca(int id, string descripcion)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id", id, "Se esta intentando asignar un ID menor o igual a cero en un objeto Marca");
            }
            if (descripcion.Length >= 50)
            {
                throw new ArgumentOutOfRangeException("descipcion", descripcion, "Se esta intentando asignar una descripcion demasiado largo en un objeto Marca");
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
