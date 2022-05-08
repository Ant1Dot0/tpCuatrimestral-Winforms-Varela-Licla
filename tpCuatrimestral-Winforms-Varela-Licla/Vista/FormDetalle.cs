using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using dominio;

namespace Vista
{
    public partial class FormDetalle : Form
    {
        public FormDetalle()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            articulo = negocio.buscarArtCodigo(txbCodigo.Text);

            txtCodigo.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescripcion.Text = articulo.descripcion; 
            txtCategoria.Text = "" + articulo.categoria;
            txtMarca.Text = "" + articulo.marca;
            txtPrecio.Text = "" + articulo.precio;

            cargarImagen(articulo.imagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://educacionprivada.org/wp-content/plugins/all-in-one-video-gallery/public/assets/images/placeholder-image.png");
            }
        }
    }
}
