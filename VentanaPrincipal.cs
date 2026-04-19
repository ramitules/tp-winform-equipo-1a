using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_1A
{
  public partial class VentanaPrincipal : Form
  {
    public VentanaPrincipal()
    {
      InitializeComponent();
    }

    private void VentanaPrincipal_Load(object sender, EventArgs e)
    {
        Negocio negocio = new Negocio();
        tbxPrueba.Text = negocio.lisar()[0].Nombre; //Esto hay que modificar para que se carguen los datos en el DataGridView
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
