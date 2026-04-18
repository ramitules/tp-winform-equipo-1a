using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_1A
{
    internal class Categoria
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
        public override string ToString()
        {
            return descripcion;
        }
}
}
