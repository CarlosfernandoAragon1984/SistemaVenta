using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IVenta
    {
        int IdVenta { get; set; }
        Usuario usuario { get; set; }
        string TipoDocumento { get; set; }
        string NuemroDocumento { get; set; }
        string ClienteDocumento { get; set; }
        string ClienteNombre { get; set; }
        decimal Pago { get; set; }
        decimal Cambio { get; set; }
        decimal Total { get; set; }
        List<DetalleVenta> DetalleVenta { get; set; }
        DateTime FechaRegistro { get; set; }
    }
}
