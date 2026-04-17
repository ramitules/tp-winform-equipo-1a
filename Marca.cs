using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_1A
{
    internal class Marca
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
            get { 
                return nombre; 
            }
        
        
        }
    }
}
