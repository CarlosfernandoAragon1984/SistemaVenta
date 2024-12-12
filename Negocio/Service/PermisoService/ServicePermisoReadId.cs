using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio.Service.PermisoService
{
    public class ServicePermisoReadId
    {
        private readonly IReadRepositoryID<Permiso> _permiso;
        public ServicePermisoReadId(IReadRepositoryID<Permiso> permiso)
        {
            _permiso = permiso;
        }
        public List<Permiso> ListPermisoID(Usuario user){return _permiso.Select(user);}
    }
}
