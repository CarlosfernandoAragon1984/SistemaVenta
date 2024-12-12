using Conexion;
using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repository.PermisoRepository
{
    public class RepositoryPermisoReadId: IReadRepositoryID<Permiso>
    {
        public List<Permiso> Select (Usuario user)
        {
            List<Permiso> lista = new List<Permiso>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetProsedimiento("storedListarPermiso");
                datos.SetParametros("@IdUsuario", user.IdUsuario);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Permiso aux = new Permiso();
                    aux.rol = new Rol();
                    if (!(datos.Lector["IdRol"] is DBNull))
                    {
                        aux.rol.IdRol = (Int16)datos.Lector["IdRol"];
                    }
                    if (!(datos.Lector["NombreMenu"] is DBNull))
                    {
                        aux.NombreMenu = (string)datos.Lector["NombreMenu"];
                    }
                    if (!(datos.Lector["NombreCompleto"] is DBNull))
                    {
                        user.NombreCompleto = (string)datos.Lector["NombreCompleto"];
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
