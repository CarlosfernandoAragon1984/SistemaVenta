using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IDetalleCompra
    {
         int IdDetalleCompra { get; set; }
         Producto producto { get; set; }
         decimal PrecioVenta { get; set; }
         decimal PrecioCompra { get; set; }
         int Cantidad { get; set; }
         decimal MontoTotal { get; set; }
         DateTime FechaRegistro { get; set; }
    }
}
