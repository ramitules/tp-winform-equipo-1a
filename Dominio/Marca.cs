using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        private int id;
        public int Id { get; set; }

        private string nombre;
        public string Nombre {
            set
            {
                if (value.Length < 50)
                {
                    nombre = value;
                }
            }
            get
            {
                return nombre;
            }         
        }

        //Sobreescribo el metodo ToString para que me muestre la marca en vez del tipo de dato.
        public override string ToString()
        {
            return Nombre;
        }
    }
}
