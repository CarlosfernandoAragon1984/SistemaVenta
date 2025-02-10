using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service.ProductoService
{
    public class ReadProductoService
    {
        private readonly IReadRepository<Producto> _Service;
        public ReadProductoService(IReadRepository<Producto> Service)
        {
            _Service = Service;
        }

        public List<Producto> Select() { return _Service.Select(); }
        
            
    }
}
