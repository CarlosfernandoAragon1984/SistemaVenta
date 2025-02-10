using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio.Service.CategoriaService
{
    public class UpdateCategoriaService
    {
        private readonly IUpdateRepository<Categoria> _categoria;

        public UpdateCategoriaService(IUpdateRepository<Categoria> categoria)
        {
            _categoria = categoria;
        }
        public void Update(Categoria categoria) { _categoria.Update(categoria); }
    }
}
