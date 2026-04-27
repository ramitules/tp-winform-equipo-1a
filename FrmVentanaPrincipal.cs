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

            cboBoxCampo.DataSource = new List<string> { "Articulo", "Nombre", "Marca", "Categoria", "Descripcion" };
            cboBoxCriterio.DataSource = new List<string> { "Contiene", "Exacto" };
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
                ocultarColumnas();
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
            if (articuloActual.Imagen != null && articuloActual.Imagen.Count > 0)
            {
                string img = articuloActual.Imagen[indiceActual];
                mostrarImagen(img);
            }
            else
            {               
                mostrarImagen("mostrarNada");
            }
            string url = articuloActual.Imagen[indiceActual] != null ? articuloActual.Imagen[indiceActual] : "";
            mostrarImagen(url);
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

        private void btnArticuloEliminar_Click(object sender, EventArgs e)
        {
            // Validacion: al menos una fila seleccionada
            if (dgvArticulos.CurrentRow == null)
            {   
                MessageBox.Show("No hay ningun articulo seleccionado");
                return;
            }
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

        private void SeleccionarFila()
        {
            // Validacion: al menos una fila seleccionada
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningun articulo seleccionado");
                return;
            }
           
              

            Articulo seleccionado;
            string codigo = dgvArticulos.CurrentRow.Cells["CodArticulo"].Value.ToString();
            seleccionado = ListaArticulos.Find(x => x.CodArticulo == codigo);

            FrmArticuloAgregar modif = new FrmArticuloAgregar(seleccionado);
            modif.ShowDialog();
            Cargar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarFila();
        }
        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string busqueda = txtBoxBuscar.Text;
            lblResultadoBusqueda.Visible = false;

            if (busqueda.Length > 1)
            {
                //Filtro por nombre o codigo de articulo
                listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(txtBoxBuscar.Text.ToUpper()) || x.CodArticulo.ToUpper().Contains(txtBoxBuscar.Text.ToUpper()));

            }
            else
            {
                listaFiltrada = ListaArticulos;
            }

            // Mostrar resultado de la busqueda

           
            lblResultadoBusqueda.Visible = false;
            dgvArticulos.DataSource = null; //Siempre hay que hacer una limpieza antes de pisar el DataSource, sino no se actualiza el DataGridView
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
            if (listaFiltrada.Count == 0)
            {
                lblResultadoBusqueda.Visible = true;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtBoxBusquedaAvanzada.Text == "")
            {
                MessageBox.Show("Ingrese un valor para la busqueda");
                return;
            }
            else if (cboBoxCampo.SelectedItem == null && cboBoxCriterio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo y un criterio de busqueda");
                return;
            }
            else if (cboBoxCampo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo de busqueda");
                return;
            }
            else if (cboBoxCriterio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio de busqueda");
                return;
            }
            


            List<Articulo> listaFiltrada;
            listaFiltrada = ListaArticulos; // Inicializo la lista filtrada con la lista completa, para luego ir filtrando segun los criterios seleccionados
            lblResultadoBusqueda.Visible = false;

            string busqueda = txtBoxBusquedaAvanzada.Text;
            string campo = cboBoxCampo.SelectedItem.ToString();
            string criterio = cboBoxCriterio.SelectedItem.ToString();

            switch (campo)
            {
                case "Articulo":
                    if (criterio == "Contiene")
                        listaFiltrada = ListaArticulos.FindAll(x => x.CodArticulo.ToUpper().Contains(busqueda.ToUpper()));
                    else
                        listaFiltrada = ListaArticulos.FindAll(x => x.CodArticulo.ToUpper() == busqueda.ToUpper());
                    break;
                case "Nombre":
                    if (criterio == "Contiene")
                        listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(busqueda.ToUpper()));
                    else
                        listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper() == busqueda.ToUpper());
                    break;
                case "Marca":
                    if (criterio == "Contiene")
                        listaFiltrada = ListaArticulos.FindAll(x => x.Marca.Descripcion.ToUpper().Contains(busqueda.ToUpper()));
                    else
                        listaFiltrada = ListaArticulos.FindAll(x => x.Marca.Descripcion.ToUpper() == busqueda.ToUpper());
                    break;
                case "Categoria":
                    if (criterio == "Contiene")
                        listaFiltrada = ListaArticulos.FindAll(x => x.Categoria.Descripcion.ToUpper().Contains(busqueda.ToUpper()));
                    else
                        listaFiltrada = ListaArticulos.FindAll(x => x.Categoria.Descripcion.ToUpper() == busqueda.ToUpper());
                    break;
                case "Descripcion":
                    if (criterio == "Contiene")
                        listaFiltrada = ListaArticulos.FindAll(x => x.Descripcion.ToUpper().Contains(busqueda.ToUpper()));
                    else
                        listaFiltrada = ListaArticulos.FindAll(x => x.Descripcion.ToUpper() == busqueda.ToUpper());
                    break;

                default:
                    break;
            }

            if (listaFiltrada.Count == 0)
            {
                MessageBox.Show("Busqueda sin resultados");
            }

            dgvArticulos.DataSource = null; //Siempre hay que hacer una limpieza antes de pisar el DataSource, sino no se actualiza el DataGridView
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnBorrarFiltroRapido_Click(object sender, EventArgs e)
        {
            Cargar();
            txtBoxBuscar.Clear();
        }

        private void btnBorrarFiltroAv_Click(object sender, EventArgs e)
        {
            Cargar();
            cboBoxCampo.SelectedIndex = 0;
            cboBoxCriterio.SelectedIndex = 0;
            txtBoxBusquedaAvanzada.Clear();
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila();
        }
    }
}
