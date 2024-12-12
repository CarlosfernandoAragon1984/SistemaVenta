using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IDetalleVenta
    {
       int IdDetalleVenta { get; set; }
        Producto producto { get; set; }
        decimal PrecioVenta { get; set; }
        int Cantidad { get; set; }
        decimal SubTotal { get; set; }
        DateTime FechaRegistro { get; set; }
    }
}
