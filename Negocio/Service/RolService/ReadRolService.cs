using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio.Service.RolService
{
    public class ReadRolService
    {
        private readonly IReadRepository<Rol> _rol;

        public ReadRolService(IReadRepository<Rol> rol)
        {
            _rol = rol;
        }
        public List<Rol> GetRolList() { return _rol.Select(); }
    }
}
