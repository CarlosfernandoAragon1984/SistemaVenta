using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IProducto
    {
         int IdProducto { get; set; }
         string Codigo { get; set; }
         string Nombre { get; set; }
         Categoria categoria { get; set; }
         int Stock { get; set; }
         decimal PrecioVenta { get; set; }
         decimal PrecioCompra { get; set; }
         bool Estado { get; set; }
         DateTime FechaRegistro { get; set; }
    }
}
