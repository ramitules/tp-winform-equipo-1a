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
  public partial class FrmVentanaPrincipal : Form
  {
    public FrmVentanaPrincipal()
    {
      InitializeComponent();
    }

    private void VentanaPrincipal_Load(object sender, EventArgs e)
    {
        try
        {
            Negocio negocio = new Negocio();
            dgvArticulos.DataSource = negocio.lisar();
            //throw new Exception("Mensaje de prueba - Error al cargar los datos"); - Esta linea es para ver que captura el error y lo muestra son trabar el progrma.
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArticuloAgregar ventana = new FrmArticuloAgregar();
            ventana.ShowDialog();
        }
    }
}
