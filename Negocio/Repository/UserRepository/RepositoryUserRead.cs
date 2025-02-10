using Negocio.Interface;
using Dominio;
using Conexion;
using System.Collections.Generic;
using System;


namespace Negocio.Repository.UserRepository
{
    public class RepositoryUserRead: IReadRepository<Usuario>
    {
       public List<Usuario> Select()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetProsedimiento("spLista_Usurio");
               // datos.SetConsulta("Select IdUsuario,Documento,NombreCompleto,Correo,Clave,Estado from USUARIO");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                   //
                    aux.IdUsuario = (Int16)datos.Lector["IdUsuario"];
                   //
                    if (!(datos.Lector["Documento"] is DBNull))
                    {
                        aux.Documento = (string)datos.Lector["Documento"];
                    }
                    //
                    if (!(datos.Lector["NombreCompleto"] is DBNull))
                    {
                        aux.NombreCompleto = (string)datos.Lector["NombreCompleto"];
                    }
                    //
                    if (!(datos.Lector["Correo"] is DBNull))
                    {
                        aux.Email = (string)datos.Lector["Correo"];
                    }
                    //
                    if (!(datos.Lector["Clave"] is DBNull))
                    {
                        aux.Clave = (string)datos.Lector["Clave"];
                    }
                    //
                    if (!(datos.Lector["Telefono"] is DBNull))
                    {
                        aux.Telefono = (string)datos.Lector["Telefono"];
                    }
                    //
                    if (!(datos.Lector["Estado"] is DBNull))
                    {
                        aux.Estado = (bool)datos.Lector["Estado"];
                    }
                   //
                    aux.rol= new Rol();
                   
                    aux.rol.IdRol = (Int16)datos.Lector["IdRol"];
                    //
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.rol.Descripcion = (string)datos.Lector["Descripcion"]; 
                    }
                   
                   
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
                datos.CerrarConexion();
            }
        }
    }
}

