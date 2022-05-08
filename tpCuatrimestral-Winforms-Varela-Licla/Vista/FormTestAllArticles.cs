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
    public partial class FormTestAllArticles : Form
    {
        private  List<Articulo> listaArticulos;//Se carga para poder manupular la lista despues. los datos de la base estan aca 

        public FormTestAllArticles()
        {
            InitializeComponent();
        }

        private void frmConsultaTodosLoad(object sender, EventArgs e)
        {

        }

        private void cargarImagen(string imagen) //si la imagen falla entonces muestra imagen x defecto
        {
            try
            {
                PBXAllArticles.Load(imagen);
            }
            catch (Exception ex)
            {
                PBXAllArticles.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void FormTestAllArticles_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                DGVAllArticles.DataSource = listaArticulos; //cargo la grilla
                //DGVAllArticles.Columns["imageUrl"].Visible=false;
                cargarImagen(listaArticulos[0].imagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                DGVAllArticles.DataSource = listaArticulos; //cargo la grilla
                DGVAllArticles.Columns["id"].Visible=false;
                //DGVAllArticles.Columns["imagenUrl"].Visible = false;
                cargarImagen(listaArticulos[0].imagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void DGVAllArticles_SelectionChanged(object sender, EventArgs e) //en cada seleccion actualiza la imagen
        {
           Articulo seleccionado = (Articulo)DGVAllArticles.CurrentRow.DataBoundItem; // de la fila actual obtiene el obj enlazado. devuelve obj.
           cargarImagen(seleccionado.imagenUrl);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DGVAllArticles.CurrentRow.DataBoundItem; //selecciono el registro

            FormAgregar modificar = new FormAgregar(seleccionado); // le paso el reg. seleccionado al constructor
            modificar.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
            cargar();
        }
    }
}







   

