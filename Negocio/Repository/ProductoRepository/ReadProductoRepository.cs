using Conexion;
using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repository.ProductoRepository
{
    public class ReadProductoRepository : IReadRepository<Producto>
    {
        public List<Producto> Select()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetProsedimiento("ListaProductos");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.IdProducto = (Int16)datos.Lector["IdProducto"];
                   
                    if (!(datos.Lector["Codigo"] is DBNull))
                    {
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    }
                    if (!(datos.Lector["Nombre"] is DBNull))
                    {
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    }

                    aux.categoria= new Categoria();

                    aux.categoria.IdCategoria = (Int16)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }


                    if (!(datos.Lector["Stock"] is DBNull))
                    {
                        aux.Stock = (int)datos.Lector["Stock"];
                    }
                    if (!(datos.Lector["PrecioVenta"] is DBNull))
                    {
                        aux.PrecioCompra = (decimal)datos.Lector["PrecioVenta"];
                    }
                    if (!(datos.Lector["PrecioCompra"] is DBNull))
                    {
                        aux.PrecioCompra = (decimal)datos.Lector["PrecioCompra"];
                    }
                    if (!(datos.Lector["Estado"] is DBNull))
                    {
                        aux.Estado = (bool)datos.Lector["Estado"];
                    }
                    if (!(datos.Lector["FechaRegistro"] is DBNull))
                    {
                        aux.FechaRegistro = (DateTime)datos.Lector["FechaRegistro"];
                    }




                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
