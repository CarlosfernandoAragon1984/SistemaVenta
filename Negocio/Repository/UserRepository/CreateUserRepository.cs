﻿using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexion;

namespace Negocio.Repository.UserRepository
{
    public class CreateUserRepository:ICreateRepository<Usuario>
    {
        public void Create(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetProsedimiento("sp_createUsuario");
                datos.SetParametros("@Documento", usuario.Documento);
                datos.SetParametros("@NombereCompleto",usuario.NombreCompleto);
                datos.SetParametros("@Correo",usuario.Email);
                datos.SetParametros("@Clave",usuario.Clave);
                datos.SetParametros("@IdRol",usuario.rol.IdRol);
                datos.SetParametros("@Telefono",usuario.Telefono);
                datos.SetParametros("@Estado",usuario.Estado);
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
