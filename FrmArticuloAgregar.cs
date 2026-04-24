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
    public partial class FrmArticuloAgregar : Form
    {
        public FrmArticuloAgregar()
        {
            InitializeComponent();
        }

        private void ArticuloAgregar_Load(object sender, EventArgs e)
        {
            //Cargo la lista de categorias y marcas en los despegables al cargar el formulario.

            CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
            MarcaNegocio MarcaNegocio = new MarcaNegocio();

            try
            {
                cBoxCategoria.DisplayMember = "Descripcion"; //Le indico que muestre la descripcion de la categoria.
                cBoxCategoria.ValueMember = "Id"; //Le indico lo que debe capturar como valor.
                cBoxCategoria.DataSource = CategoriaNegocio.listar();
                
                cBoxMarca.DisplayMember = "Descripcion"; 
                cBoxMarca.ValueMember = "Id"; 
                cBoxMarca.DataSource = MarcaNegocio.listar();
                
                //agregado
                pbxImagenNueva.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }


            String codArticulo = txtBoxCodArticulo.Text;
            String nombre = txtBoxNombre.Text;
            String descripcion = txtBoxDescripcion.Text;
            int marca = (int)cBoxMarca.SelectedValue; //Te cambie esta linea.
            int categoria = (int)cBoxCategoria.SelectedValue; //Y esta otra.
            String imagen = txtBoxImagen.Text;
            decimal precio = numPrecio.Value;

            string texto = $"Id: -- \r\n CodArt: {codArticulo}\r\n Nombre: {nombre}\r\n Descripcion: {descripcion}\r\n Precio: {precio}\r\n MarcaDesc: {marca}\r\nCategoriaId: {categoria}\r\nImagenes: {imagen}";

            txtCargaArticulo.Text = texto;

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                articulo.CodArticulo = txtBoxCodArticulo.Text;
                articulo.Nombre = txtBoxNombre.Text;
                articulo.Descripcion = txtBoxDescripcion.Text;
                articulo.Precio = numPrecio.Value;

                //En los despegables hago el casteo explicito indicandole qué tipo de objeto estoy agarrando (6.32´ del video).
                articulo.Marca = (Marca)cBoxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cBoxCategoria.SelectedItem;

                articuloNegocio.agregar(articulo);
                MessageBox.Show("Articulo agregado exitosamente");

                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        //Evento para eliminar
        private void txtBoxCodArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text.Trim() != "")
            {
                lblNombre.Visible = false;
            }
            else
            {
                lblNombre.Visible = true;
            }
        }

        private void txtBoxCodArticulo_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCodArticulo.Text.Trim() != "")
            {
                lblCodigo.Visible = false;
            }
            else
            {
                lblCodigo.Visible = true;
            }
        }

        private void txtBoxImagen_TextChanged(object sender, EventArgs e)
        {
            string urlImagenNueva = txtBoxImagen.Text;
            mostrarImagen(urlImagenNueva);
        }
        public void mostrarImagen(string url)
        {
            try
            {
                pbxImagenNueva.Load(url);
            }
            catch (Exception ex)
            {
                pbxImagenNueva.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }
    }
}
