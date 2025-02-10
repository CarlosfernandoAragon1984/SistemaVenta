using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexion;

namespace Negocio.Repository.UserRepository
{
    public class UpdateUserRepository:IUpdateRepository<Usuario>
    {
        /*¿Qué es la inyección de dependencias?*/
        /* 2) Implementaciones: Se crean clases que implementan esa interfaz.*/
        public void Update(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetProsedimiento("_spUdateUser");
                datos.SetParametros("@IdUsuario", usuario.IdUsuario);
                datos.SetParametros("@Documento", usuario.Documento);
                datos.SetParametros("@NombereCompleto", usuario.NombreCompleto);
                datos.SetParametros("@Correo", usuario.Email);
                datos.SetParametros("@Clave", usuario.Clave);
                datos.SetParametros("@IdRol", usuario.rol.IdRol);
                datos.SetParametros("@Telefono", usuario.Telefono);
                datos.SetParametros("@Estado", usuario.Estado);
                datos.EjecutarAccionScalar();
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
