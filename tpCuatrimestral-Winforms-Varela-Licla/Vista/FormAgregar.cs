using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace Vista
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void BtnAceptar_Click(object sender, EventArgs e) // parte de front
        {
            Articulo nuevoArt = new Articulo();   
            ArticuloNegocio negocio = new ArticuloNegocio();    

            try
            {
                nuevoArt.codigo = txtCodeArt.Text;
                nuevoArt.nombre = TxtNameArt.Text;
                nuevoArt.descripcion = TxtDesc.Text;
                nuevoArt.imagenUrl = TxtImagenUrl.Text;  
                nuevoArt.precio = decimal.Parse(txtPrecio.Text);

                negocio.agregar(nuevoArt); //aca esta la logica
                MessageBox.Show("Agregado exitosamente");
                Close();    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                CboCategoria.DataSource = categoriaNegocio.listar();
               // CboMarca = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
