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

            
            txbNombre.Text = articulo.nombre;
            txbDescripcion.Text = articulo.descripcion;
            txbMarca.Text = articulo.marca.id.ToString();
            txbCategoria.Text =  articulo.categoria.id.ToString();
            txbPrecio.Text = articulo.precio.ToString();

        }
    }
}
