using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDB;
using Dominio;
using Negocio;


namespace TPWinForm_equipo_1A
{
    public partial class FrmArticuloAgregar : Form
    {
        private Articulo articuloTraido;
        private List<string> listaVieja = new List<string>();
        private List<string> listaNueva;
        private bool articuloNuevo = true;

        private bool camposObligatorios = false;
        private bool precioMayorACero = false;
        private bool existenCambios = false;
        private bool existenCambiosEnImg = false;

        public FrmArticuloAgregar()
        {
            InitializeComponent();
        }

        public FrmArticuloAgregar(Articulo art) // creo un nuevo constructor con un parametro del tipo Articulo. Si se instancia con un argumento del tipo Articulo se setean todos los valores del campo con las propiedades del objeto
        {
            InitializeComponent();
            articuloNuevo = false;
            articuloTraido = art; //creo una variable del tipo Articulo y le asigno el valor del parametro que me llega para usarlo como comparador.
            this.listaVieja = art.Imagen;
            this.Text = "Descripcion Artículo"; //Esto le cambia el titulo a la ventana.
            txtBoxCodArticulo.Text = art.CodArticulo;
            txtBoxNombre.Text = art.Nombre;
            txtBoxDescripcion.Text = art.Descripcion;
            numPrecio.Value = art.Precio;
            txtBoxImagen.Text = art.Imagen[0];
            cBoxMarca.SelectedValue = art.Marca.Id;
            cBoxCategoria.SelectedValue = art.Categoria.Id; 
            txtBoxCodArticulo.ReadOnly = true; 
            txtBoxNombre.ReadOnly = true;
            txtBoxDescripcion.ReadOnly = true;
            txtBoxImagen.ReadOnly = true;
            btnGestionarImagen.Visible = true;
            
            btnAgregarMarca.Enabled = false;
            btnEliminarMarca.Enabled = false;
            btnAgregarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
            numPrecio.Enabled = false;
            cBoxMarca.Enabled = false;
            cBoxCategoria.Enabled = false;
            btnModificarArticulo.Visible = true;
            btnEliminarArticulo.Visible = true;
            btnAceptar.Enabled = false;
        }

        private void ArticuloAgregar_Load(object sender, EventArgs e)
        {
            //Cargo la lista de categorias y marcas en los despegables al cargar el formulario.
            try
            {
                CargarComboCategoria();
                CargarComboMarca();

                //pbxImagenNueva.Load("https://media..) esta linea la saco para poner una funcion que cargue la imagen.
                mostrarImagen(txtBoxImagen.Text); //carga la primer imagen del obeto, si la tiene claro. 
                ValidaTodoConFuncionesIndividuales();
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
            //btnAceptar.Enabled = existenCambios();
            ValidaTodoConFuncionesIndividuales();
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
            //btnAceptar.Enabled = existenCambios();
            ValidaTodoConFuncionesIndividuales();
        }

        private void txtBoxImagen_TextChanged(object sender, EventArgs e)
        {
            string urlImagenNueva = txtBoxImagen.Text;
            mostrarImagen(urlImagenNueva);
            //if (!articuloNuevo)
                //btnAceptar.Enabled = existenCambios();
        }  //Este capas ya no sirva
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

        private void labelImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            txtBoxCodArticulo.ReadOnly = false;
            txtBoxNombre.ReadOnly = false;
            txtBoxDescripcion.ReadOnly = false;
            //txtBoxImagen.ReadOnly = false;
            numPrecio.Enabled = true;
            cBoxMarca.Enabled = true;
            cBoxCategoria.Enabled = true;
            btnGestionarImagen.Enabled = true;
            
            btnAgregarMarca.Enabled = true;
            btnEliminarMarca.Enabled = true;
            btnAgregarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;
            
        }

        public bool validarCambioCampos()
        {
            if (articuloNuevo)
            {
                return true;
            }
            string codNuevo = txtBoxCodArticulo.Text;
            string nombreNuevo = txtBoxNombre.Text;
            string descripcionNueva = txtBoxDescripcion.Text;
            decimal precioNuevo = numPrecio.Value;
            string imagenNueva = txtBoxImagen.Text;

            //Una aclaracion que me hizo recontra renegar. Cuando se cargan los campos comboBox, se dispara el evento de cambio que dispara la funcion de validarCampos,
            //pero en ese momento no existen valores cargados por defecto, sino que se encuentra el campo vacio y devuelve un null que es imposible de castear a int
            //y hace que la app explore
            int marcaNueva = cBoxMarca.SelectedValue is int m ? m : -1;
            int categoriaNueva = cBoxCategoria.SelectedValue is int c ? c : -1;
           
            //string imagenVieja = (articuloTraido.Imagen != null && articuloTraido.Imagen.Count > 0) ? articuloTraido.Imagen[0] : ""; ///////////////////////////////////////

            if (codNuevo.Trim() != articuloTraido.CodArticulo.Trim() ||
                nombreNuevo.Trim() != articuloTraido.Nombre.Trim() ||
                descripcionNueva.Trim() != articuloTraido.Descripcion.Trim() ||
                precioNuevo != articuloTraido.Precio ||
                //imagenNueva.Trim() != imagenVieja.Trim() ||/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                marcaNueva != articuloTraido.Marca.Id ||
                categoriaNueva != articuloTraido.Categoria.Id)
            {
                return true;
            }

            return false;
        }// este lo cree de nuevo mas reorganizado para que centralice todo

        private void txtBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidaTodoConFuncionesIndividuales();
            //refrescarBotonAceptar();
        }

        private void cBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refrescarBotonAceptar();
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refrescarBotonAceptar();
        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {
            ValidaTodoConFuncionesIndividuales();
            //refrescarBotonAceptar();
        }

        private void btnGestionarImagen_Click(object sender, EventArgs e)
        {
            if(articuloTraido != null)
            {
                FrmGestionImagenes gestImg = new FrmGestionImagenes(articuloTraido);
                if (gestImg.ShowDialog() == DialogResult.OK)
                {                  
                    List<string> listaNueva = gestImg.ListaImagenesFinal;

                    if (huboCambioEnImagenes(articuloTraido.Imagen, listaNueva))
                    {
                        this.listaNueva = gestImg.ListaImagenesFinal;

                        string imagenAMostrar = (listaNueva != null && listaNueva.Count > 0) ? listaNueva[0] : "";
                        mostrarImagen(imagenAMostrar);
                        existenCambiosEnImagenes();//nueva linea convertiria variable global en true si cambio algo de las imagenes 
                        ValidaTodoConFuncionesIndividuales();
                        //refrescarBotonAceptar();
                    }
                    else
                    {
                        //btnAceptar.Enabled = false;
                    }
                }
            }
            else
            {
                FrmGestionImagenes gestImg = new FrmGestionImagenes();
                gestImg.ShowDialog();
            }
        }
        public bool huboCambioEnImagenes(List<string> listaVieja, List<string> listaNueva)
        {
            if (listaNueva == null)
            {
                return false;
            }
            if (listaVieja.Count != listaNueva.Count)
            {
                return true;
            }
            for (int i = 0; i < listaVieja.Count; i++)
            {
                if (listaVieja[i].Trim() != listaNueva[i].Trim())
                {
                    return true;
                }
            } 
            return false;
        }
        public bool existenCambioss()
        {

            if (validarCambioCampos() || huboCambioEnImagenes(this.listaVieja, this.listaNueva))
            {
                return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int idArticulo;
                if (articuloNuevo)
                {
                    datos.ConsultaDatos("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@codigo, @nombre, @desc, @idMarca, @idCat, @precio) SELECT CAST(SCOPE_IDENTITY() AS INT);");

                    datos.SetParametro("@codigo", txtBoxCodArticulo.Text);
                    datos.SetParametro("@nombre", txtBoxNombre.Text);
                    datos.SetParametro("@desc", string.IsNullOrWhiteSpace(txtBoxDescripcion.Text) ? (object)DBNull.Value : txtBoxDescripcion.Text);
                    datos.SetParametro("@idMarca", cBoxMarca.SelectedValue);
                    datos.SetParametro("@idCat", cBoxCategoria.SelectedValue);
                    datos.SetParametro("@precio", numPrecio.Value);
                    idArticulo = datos.EjecutarEscalar();
                    

                }
                else
                {
                    idArticulo = articuloTraido.ID;

                    datos.ConsultaDatos("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idMarca, IdCategoria = @idCat, Precio = @precio WHERE Id = @id");
                    datos.SetParametro("@codigo", txtBoxCodArticulo.Text);
                    datos.SetParametro("@nombre", txtBoxNombre.Text);
                    datos.SetParametro("@desc", string.IsNullOrWhiteSpace(txtBoxDescripcion.Text) ? (object)DBNull.Value : txtBoxDescripcion.Text);
                    datos.SetParametro("@idMarca", cBoxMarca.SelectedValue);
                    datos.SetParametro("@idCat", cBoxCategoria.SelectedValue);
                    datos.SetParametro("@precio", numPrecio.Value);
                    datos.SetParametro("@id", idArticulo);
                    datos.EjecutarAccion();
                }
                AccesoDatos datosImg = new AccesoDatos();
                datosImg.ConsultaDatos("DELETE FROM IMAGENES where IdArticulo = @Id");
                datosImg.SetParametro("@Id", idArticulo);
                datosImg.EjecutarAccion();
                if (this.listaNueva != null && this.listaNueva.Count > 0)
                {
                    foreach (var imagen in this.listaNueva)
                    {   
                        datosImg = new AccesoDatos();
                        try
                        {
                            datosImg.ConsultaDatos("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@Id, @Imagen)");
                            datosImg.SetParametro("@Id", idArticulo);
                            datosImg.SetParametro("@Imagen", imagen);
                            datosImg.EjecutarAccion();
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            datosImg.CerrarConexion();
                        }
                    }
                }
                MessageBox.Show("Guardado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar imagen: " + ex.Message);
            }
            Close();
        }
        private bool ValidarCondiciones()
        {
            if (string.IsNullOrWhiteSpace(txtBoxCodArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNombre.Text) ||
                numPrecio.Value <= 0)
            {
                return false;
            }
            if (articuloNuevo)
            {
                return true;
            }
            int idMarca = cBoxMarca.SelectedValue != null ? (int)cBoxMarca.SelectedValue : 0;
            int idCategoria = cBoxCategoria.SelectedValue != null ? (int)cBoxCategoria.SelectedValue : 0;
            //Este codigo es para ver si existen cambios
            bool huboCambioEnTexto =
                txtBoxCodArticulo.Text.Trim() != articuloTraido.CodArticulo.Trim() ||
                txtBoxNombre.Text.Trim() != articuloTraido.Nombre.Trim() ||
                txtBoxDescripcion.Text.Trim() != articuloTraido.Descripcion.Trim() ||
                numPrecio.Value != articuloTraido.Precio ||
                idMarca != articuloTraido.Marca.Id ||
                idCategoria != articuloTraido.Categoria.Id;

            bool huboCambioFotos = VerificarCambioFotos(listaVieja, listaNueva);

            return huboCambioEnTexto || huboCambioFotos;
        }
        private bool VerificarCambioFotos(List<string> vieja, List<string> nueva)
        {
            if (vieja == null || nueva == null) 
            {
                return vieja != nueva;
            }
            if (vieja.Count != nueva.Count)
            { 
                return true; 
            }

            for (int i = 0; i < vieja.Count; i++)
            {
                if (vieja[i].Trim() != nueva[i].Trim())
                {
                    return true;
                } 
            }
            return false;
        }
        private void refrescarBotonAceptar()
        {
            btnAceptar.Enabled = ValidarCondiciones();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();          
            try
            {
                DialogResult respuesta = MessageBox.Show("Confirmar eliminacion?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {                 
                    negocio.eliminar(articuloTraido.ID);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void existenCambiosEnImagenes()
        {
            if (listaNueva == null)
            {
                existenCambiosEnImg = false;
                return;
            }
            if (listaVieja.Count != listaNueva.Count)
            {
                existenCambiosEnImg = true;
                return;
            }
            for (int i = 0; i < listaVieja.Count; i++)
            {
                if (listaVieja[i].Trim() != listaNueva[i].Trim())
                {
                    existenCambiosEnImg = true;
                    return;
                }
            }
            existenCambiosEnImg = false;
        }//Nueva creada
        public void validarPrecio()
        {
            if (numPrecio.Value > 0)
            {
                precioMayorACero = true;
            }
            else
            {
                precioMayorACero = false;
            }
        }//Nueva creada
        public void cambioAlgunCampo()
        {
            if (!articuloNuevo)
            {
                string codNuevo = txtBoxCodArticulo.Text;
                string nombreNuevo = txtBoxNombre.Text;
                string descripcionNueva = txtBoxDescripcion.Text;
                decimal precioNuevo = numPrecio.Value;
                if (articuloTraido.CodArticulo != codNuevo || articuloTraido.Nombre != nombreNuevo || articuloTraido.Descripcion != descripcionNueva || articuloTraido.Precio != precioNuevo)
                {
                    existenCambios = true;
                }
                else
                {
                    existenCambios = false;
                }
            }
            else
            {
                existenCambios = true;
            }
        }//Nueva creada
        public void camposObligatoriosCompletos()
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCodArticulo.Text) && !string.IsNullOrWhiteSpace(txtBoxNombre.Text))
            {
                camposObligatorios = true;
            }
            else
            {
                camposObligatorios = false;
            }
        }//Nueva creada
        public void ValidaTodoConFuncionesIndividuales()
        {
            existenCambiosEnImagenes();
            validarPrecio();
            cambioAlgunCampo();
            camposObligatoriosCompletos();
            if ((camposObligatorios == true && precioMayorACero == true && existenCambios == true) || existenCambiosEnImg == true)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
