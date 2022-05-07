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
        private  List<Articulo> listaArticulos;

        public FormTestAllArticles()
        {
            InitializeComponent();
        }

        private void frmConsultaTodosLoad(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            DGVAllArticles.DataSource = listaArticulos;
           // DGVAllArticles.Columns["imagenUrl"].Visible = false;


            /*
            try
            {
                listaArticulos = negocio.listar();
                DGVConsultaTodos.DataSource = negocio.listar();
                DGVConsultaTodos.Columns["imagenUrl"].Visible = false;
                cargarImagen(listaArticulos[0].imagenUrl);
            }
            catch (Exception x1)
            {
                MessageBox.Show(x1.ToString());
                
            }
            */
        }

        private void cargarImagen(string imagen)
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


    }
}







   

