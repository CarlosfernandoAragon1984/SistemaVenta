using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio.Service
{
    public class CreateUserService
    {
        private readonly ICreateRepository<Usuario> _user;

        public CreateUserService(ICreateRepository<Usuario> user) 
        {
            _user = user; 
        }
        public void Create(Usuario usuario) { _user.Create(usuario); }
    }
}
