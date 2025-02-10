using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexion;

namespace Negocio.Repository.CategoriaRepository
{
    public class UpdateCategoriaRepository :IUpdateRepository<Categoria>
    {
        public void Update(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetProsedimiento("sp_UpdateCategoria");
                datos.SetParametros("@idCategoria", categoria.IdCategoria);
                datos.SetParametros("@Descripcion", categoria.Descripcion);
               
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
