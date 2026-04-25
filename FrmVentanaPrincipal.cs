using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dominio;
using Negocio;

namespace TPWinForm_equipo_1A
{
    public partial class FrmVentanaPrincipal : Form
    {
        private List<Articulo> ListaArticulos;
        private int indiceActual;
        private Articulo articuloActual = null;
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }
        //
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

            Cargar();
        }

        /// <summary>
        /// Con este metodo se recarga el DataGridView cuando sea necesario, no solo en la carga inicial del formulario
        /// </summary>
        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                ListaArticulos = negocio.listar();

                dgvArticulos.DataSource = ListaArticulos;
                //dgvArticulos.Columns["ID"].Visible = false;
                ocultarColumnas();

                dgvArticulos.DataSource = ListaArticulos;

                mostrarImagen(ListaArticulos[0].Imagen[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArticuloAgregar ventana = new FrmArticuloAgregar();
            ventana.ShowDialog();
            Cargar();
        }

        public void mostrarImagen(string url)
        {
            try
            {
                pbxUrl.Load(url);
            }
            catch (Exception ex)
            {
                pbxUrl.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                return;
            articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            indiceActual = 0;
            mostrarImagen(articuloActual.Imagen[indiceActual]);
            validarBotonAnteriorPosterior();
        }

        private void btnPosterior_Click(object sender, EventArgs e)
        {
            indiceActual++;
            mostrarImagen(articuloActual.Imagen[indiceActual]);
            validarBotonAnteriorPosterior();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            indiceActual--;
            mostrarImagen(articuloActual.Imagen[indiceActual]);
            validarBotonAnteriorPosterior();
        }

        public void validarBotonAnteriorPosterior()
        {
            if (articuloActual != null)
            {
                if (indiceActual == 0)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }
                if (indiceActual == articuloActual.Imagen.Count() - 1)
                {
                    btnPosterior.Enabled = false;
                }
                else
                {
                    btnPosterior.Enabled = true;
                }
            }
        }

        private void btnArticuloModificar_Click(object sender, EventArgs e)
        {
            // Validacion: al menos una fila seleccionada
            if (dgvArticulos.CurrentRow == null)
                return;

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FrmArticuloAgregar modif = new FrmArticuloAgregar();
            modif.ShowDialog();
            
            Cargar();
        }

        private void btnArticuloEliminar_Click(object sender, EventArgs e)
        {
            // Validacion: al menos una fila seleccionada
            if (dgvArticulos.CurrentRow == null)
                return;

            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Confirmar eliminacion?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    negocio.eliminar(seleccionado.ID);

                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(txtBoxBuscar.Text.ToUpper()));

            dgvArticulos.DataSource = null; //Siempre hay que hacer una limpieza antes de pisar el DataSource, sino no se actualiza el DataGridView
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
