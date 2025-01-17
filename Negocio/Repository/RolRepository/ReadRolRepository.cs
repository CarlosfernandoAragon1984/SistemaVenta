using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexion;

namespace Negocio.Repository.RolRepository
{
    public class ReadRolRepository :IReadRepository<Rol>
    {
       public List<Rol> Select()
        {
            List<Rol> lista = new List<Rol>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetProsedimiento("spRol");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Rol aux = new Rol();
                    aux.IdRol= (Int16)datos.Lector["IdRol"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
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
