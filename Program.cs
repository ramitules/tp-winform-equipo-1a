using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_1A
{
  internal class Program
  {
    static void Main(string[] args)
    {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaPrincipal()); //Linea agregada para que inicialice la ventana principal
    }
  }
}
