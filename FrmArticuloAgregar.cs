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
                cBoxCategoria.DataSource = CategoriaNegocio.listar();
                cBoxMarca.DataSource = MarcaNegocio.listar();
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
            String marca = cBoxMarca.SelectedItem.ToString();
            String categoria = cBoxCategoria.SelectedItem.ToString();
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
    }
}
