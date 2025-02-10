using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service.CategoriaService
{
    public class ReadCategoriaService
    {
        private readonly IReadRepository<Categoria> _users;
        public ReadCategoriaService(IReadRepository<Categoria> users)
        {
            _users = users;
        }
        public List<Categoria> Select() { return _users.Select(); }
    }
}

