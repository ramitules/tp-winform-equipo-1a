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

        public FrmArticuloAgregar(Articulo art)
        {
            InitializeComponent();
            this.Text = "Modificar Articulo";
            txtBoxCodArticulo.Text = art.CodArticulo;
            txtBoxNombre.Text = art.Nombre;
            txtBoxDescripcion.Text = art.Descripcion;
            numPrecio.Value = art.Precio;
            txtBoxImagen.Text = art.Imagen[0];
            cBoxMarca.SelectedValue = art.Marca.Id;
            cBoxCategoria.SelectedValue = art.Categoria.Id; 
        }

        private void ArticuloAgregar_Load(object sender, EventArgs e)
        {
            //Cargo la lista de categorias y marcas en los despegables al cargar el formulario.
            try
            {
                CargarComboCategoria();
                CargarComboMarca();

                //pbxImagenNueva.Load("https://media..) esta linea la saco para poner una funcion que cargue la imagen.
                mostrarImagen(txtBoxImagen.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarComboCategoria()
        {
            CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();

            cBoxCategoria.DisplayMember = "Descripcion";
            cBoxCategoria.ValueMember = "Id";
            cBoxCategoria.DataSource = CategoriaNegocio.listar();
        }
        private void CargarComboMarca()
        {
            MarcaNegocio MarcaNegocio = new MarcaNegocio();

            cBoxMarca.DisplayMember = "Descripcion";
            cBoxMarca.ValueMember = "Id";
            cBoxMarca.DataSource = MarcaNegocio.listar();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
 
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

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca frmMarca = new FrmAgregarMarca();
            frmMarca.Show();
            CargarComboMarca();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria frmCategoria = new FrmAgregarCategoria();
            frmCategoria.Show();
            CargarComboCategoria();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (cBoxMarca.Text == "")
                return;

            DialogResult res = MessageBox.Show($"Seguro que desea eliminar la marca {cBoxMarca.Text}?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                marcaNegocio.eliminar(cBoxMarca.Text);
                CargarComboMarca();
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (cBoxCategoria.Text == "")
                return;

            DialogResult res = MessageBox.Show($"Seguro que desea eliminar la categoria {cBoxCategoria.Text}?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                catNegocio.eliminar(cBoxCategoria.Text);
                CargarComboCategoria();
            }
        }
    }
}
