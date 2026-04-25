using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_1A
{
    public partial class FrmAgregarCategoria : Form
    {
        public FrmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            // Validar que no exista
            foreach (Categoria cat in categoriaNegocio.listar())
            {
                if (cat.Descripcion.ToLower() == txtDescripcion.Text.ToLower().Trim())
                {
                    txtDescripcion.BackColor = Color.LightSalmon;
                    return;
                }
            }

            try
            {
                categoriaNegocio.agregar(txtDescripcion.Text);
                MessageBox.Show("Categoria agregada exitosamente");

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
