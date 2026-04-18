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
  public partial class VentanaPrincipal : Form
  {
    public VentanaPrincipal()
    {
      InitializeComponent();
    }

    private void VentanaPrincipal_Load(object sender, EventArgs e)
    {
        Articulo art = new Articulo();
        Marca marca = new Marca();
        Categoria categoria = new Categoria();
        marca.Id = 1;
        marca.Nombre = "Marolio";
        categoria.Id = 2;
        categoria.Descripcion = "Comestibles";
        art.ID = 3;
        art.CodArticulo = "ll03";
        art.Nombre = "Fideos";
        art.Descripcion = "Consumibles";
        art.Precio = 150;
        art.Marca = marca;
        art.Categoria = categoria;
        art.Imagen.Add("UnaUrlCualquiera.com");

        string texto = $"Id: {art.ID}\n CodArt: {art.CodArticulo}\n Nombre: {art.Nombre}\n Descripcion: {art.Descripcion}\n Precio: {art.Precio}\n MarcaId: {art.Marca.Id}\n MarcaDesc: {art.Marca.Nombre}\nCategoriaId: {art.Categoria.Id}\nCategoriaDesc: {art.Categoria.Descripcion}\nImagenes: {(art.Imagen[0])}";

        tbxPrueba.Text = texto;
    }
    }
}
