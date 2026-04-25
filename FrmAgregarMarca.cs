using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm_equipo_1A
{
    public partial class FrmAgregarMarca : Form
    {
        public FrmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            // Validar que no exista
            foreach (Marca marca in marcaNegocio.listar())
            {
                if (marca.Descripcion.ToLower() == txtDescripcion.Text.ToLower().Trim())
                {
                    txtDescripcion.BackColor = Color.LightSalmon;
                    return;
                }
            }
            try
            {
                marcaNegocio.agregar(txtDescripcion.Text);
                MessageBox.Show("Marca agregada exitosamente");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }
    }
}
