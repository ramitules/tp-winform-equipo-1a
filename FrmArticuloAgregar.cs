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
    public partial class FrmArticuloAgregar : Form
    {
        public FrmArticuloAgregar()
        {
            InitializeComponent();
        }

        private void ArticuloAgregar_Load(object sender, EventArgs e)
        {
            ///ComboBox de Marca: Codigo (Por ahora solo Prueba)

            cBoxMarca.Items.Add("Prueba Marca 1");
            cBoxMarca.Items.Add("Prueba Marca 2"); 
            cBoxMarca.Items.Add("Prueba Marca 3");

            ///ComboBox de Categoria: Codigo (Por ahora solo Prueba)
            
            cBoxCategoria.Items.Add("Prueba Categoria 1");
            cBoxCategoria.Items.Add("Prueba Categoria 2");
            cBoxCategoria.Items.Add("Prueba Categoria 3");

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
