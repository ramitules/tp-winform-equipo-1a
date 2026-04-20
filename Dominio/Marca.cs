using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; }
        public string Nombre { get; }
        public Marca(int id, string nombre)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id", id, "Se esta intentando asignar un ID menor o igual a cero en un objeto Marca");
            }
            if (nombre.Length >= 50)
            {
                throw new ArgumentOutOfRangeException("nombre", nombre, "Se esta intentando asignar un nombre demasiado largo en un objeto Marca");
            }
            Id = id;
            Nombre = nombre;
        }

        //Sobreescribo el metodo ToString para que me muestre la marca en vez del tipo de dato.
        public override string ToString()
        {
            return Nombre;
        }
    }
}
