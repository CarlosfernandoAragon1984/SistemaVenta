using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface ICompra
    {
         int IdCompra { get; set; }
         Usuario usuario { get; set; }
         Proveedor proveedor { get; set; }
         string TipoDocumento { get; set; }
         string NuemroDocumento { get; set; }
         decimal MontoTotal { get; set; }
         DateTime FechaRegistro { get; set; }
    }
}
