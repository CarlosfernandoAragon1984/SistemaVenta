using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class ServicioUserRead
    {
        private readonly IReadRepository<Usuario> _users;
        public ServicioUserRead(IReadRepository<Usuario> users)
        {
            _users = users;
        }
        public List<Usuario> ListUser() { return _users.Select(); }
    }
}
