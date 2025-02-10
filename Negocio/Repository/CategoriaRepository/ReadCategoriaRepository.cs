using Conexion;
using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repository.CategoriaRepository
{
    public class ReadCategoriaRepository:IReadRepository<Categoria>
    {
        public List<Categoria> Select()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            
           
            try
            {
                datos.SetProsedimiento("sp_ListaCategoria");
                datos.EjecutarLectura();
                while (datos.Lector.Read()) 
                {
                    Categoria aux = new Categoria();
                   
                    //
                    
                    aux.IdCategoria = (Int16)datos.Lector["IdCategoria"];
                   
                    
                    //
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    }
                   
                    //
                    if (!(datos.Lector["Estado"] is DBNull))
                    {
                        aux.Estado = (bool)datos.Lector["Estado"];
                    }
                   
                    lista.Add(aux);
                }
                return lista;
            }
             
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
