﻿using System;
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
                comando.CommandText = "SELECT codigo, nombre FROM ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();    
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = (string)lector["codigo"];
                    aux.nombre = (string)lector["nombre"];
                    //  aux.descripcion = (string)lector["descripcion"];

                    //  if (!(lector["imagenUrl"] is DBNull))
                    //      aux.imagenUrl = (string)lector["imagenUrl"];
                    //  aux.precio = (float)lector["precio"];

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

      /*  public List<Articulo> listado()
        {
           // List <Articulo> lista = new List<Articulo>
            return lista;
        }*/
    }

        
}
