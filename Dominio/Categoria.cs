using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        
        private string descripcion;
        public string Descripcion 
        { 
            get  { return descripcion; }

            set
            { 
                if (value.Length < 50)
                {
                    descripcion = value;
                }
            }
        }

        //Sobreescribo el metodo ToString para que me muestre la marca en vez del tipo de dato.
        public override string ToString()
        {
            return descripcion;
        }
}
}
