using Dominio;
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
    public partial class FrmGestionImagenes : Form
    {
        public List<string> ListaImagenesFinal { get; set; }
        Articulo articulo = null;
        public FrmGestionImagenes()
        {
            InitializeComponent();
        }
        public FrmGestionImagenes(Articulo art)
        {
            InitializeComponent();
            articulo = art;
            TextBox[] tbxImagenes = { tbxImagen1, tbxImagen2, tbxImagen3, tbxImagen4, tbxImagen5 };
            for (int i = 0; i < tbxImagenes.Length; i++)
            {
                if (i < art.Imagen.Count && art.Imagen[i] != null)
                {
                    tbxImagenes[i].Text = art.Imagen[i];
                }
                else
                {
                    tbxImagenes[i].Text = "";
                }
            }
        }
        //Cuando cambia el campo de un texBox muestra la imagen.
        private void tbxImagen1_TextChanged(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen1.Text);
        }
        private void tbxImagen2_TextChanged(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen2.Text);
        }
        private void tbxImagen3_TextChanged(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen3.Text);
        }
        private void tbxImagen4_TextChanged(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen4.Text);
        }
        private void tbxImagen5_TextChanged(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen5.Text);
        }
        public void mostrarImagen(string imagen)
        {
            try
            {
                pbxImagenGestion.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenGestion.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }// Esto hay que meterlo en una clase helper o como se escriba por ser una funcion que se utiliza en varios lugares

        //Estos metodos muestran la imagen cuando se hace click en el campo texBox.
        private void tbxImagen1_Click(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen1.Text);
        }
        private void tbxImagen2_Click(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen2.Text);
        }
        private void tbxImagen3_Click(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen3.Text);
        }
        private void tbxImagen5_Click(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen5.Text);
        }
        private void tbxImagen4_Click(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen4.Text);
        }

        private void btnCancelarGestion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarGestion_Click(object sender, EventArgs e)
        {
            ListaImagenesFinal = new List<string>();
            TextBox[] tbxImagenes = { tbxImagen1, tbxImagen2, tbxImagen3, tbxImagen4, tbxImagen5 };

            foreach (var tbx in tbxImagenes)
            {
                if (!string.IsNullOrEmpty(tbx.Text))
                    ListaImagenesFinal.Add(tbx.Text.Trim());
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmGestionImagenes_Load(object sender, EventArgs e)
        {
            mostrarImagen(tbxImagen1.Text);
        }

        
    }
}