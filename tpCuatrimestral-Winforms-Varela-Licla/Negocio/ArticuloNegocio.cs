using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace Negocio
{
    public  class ArticuloNegocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString= "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT a.Id as id, Codigo, Nombre, a.Descripcion dart, c.descripcion  categoria , m.descripcion  Marca, ImagenUrl, Precio " +
                    "from ARTICULOS a, CATEGORIAS c, MARCAS m where a.IdCategoria = c.Id and a.IdMarca = m.Id";
                comando.Connection = conexion;

                conexion.Open();    
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)lector["id"];
                    aux.codigo = (string)lector["Codigo"];
                    aux.descripcion = (string)lector["dart"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.categoria.descripcion = (string)lector["categoria"];
                    aux.marca.descripcion = (string)lector["Marca"];

                    if (!(lector["imagenUrl"] is DBNull))
                    aux.imagenUrl = (string)lector["imagenUrl"];
                    
                    aux.precio = (decimal)lector["precio"];

                    lista.Add(aux);

                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<Articulo> listado()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.setearConsulta("SELECT a.Id as id, Codigo, Nombre, a.Descripcion dart, c.descripcion  categoria , m.descripcion  Marca, ImagenUrl, Precio " +
                    "from ARTICULOS a, CATEGORIAS c, MARCAS m where a.IdCategoria = c.Id and a.IdMarca = m.Id ");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.descripcion = (string)datos.Lector["dart"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.categoria.descripcion = (string)datos.Lector["categoria"];
                    aux.marca.descripcion = (string)datos.Lector["Marca"];
                    aux.imagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        public void agregar(Articulo nuevo)
        {
            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS ( Codigo, Nombre, Descripcion,ImagenUrl, precio, idMarca, idCategoria) values (" +nuevo.codigo+ ",'"+ nuevo.nombre+"','"+ nuevo.descripcion + "','" + nuevo.imagenUrl + "','" + nuevo.precio + "', @idMarca, @idCategoria) ");
                datos.setearParametro("@idMarca", nuevo.marca.id);
                datos.setearParametro("@idCategoria",nuevo.categoria.id);

                datos.ejecutarAccion();

            
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();

            }

        }

       


        public Articulo buscarArtCodigo(string codigo)// Si no encuentra la búsqueda, devuelve id = -1
        {
            Articulo aux = new Articulo();
            AccesoaDatos datos = new AccesoaDatos();
            try
            {
                datos.setearConsulta("select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio " +
                "FROM ARTICULOS where codigo = " + "'" + codigo + "'");

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca.id = (int)datos.Lector["IdMarca"];
                    aux.categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.imagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.precio = (decimal)datos.Lector["Precio"];
                }
                else
                {
                    aux.id = -1;
                }

                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }



        
}
