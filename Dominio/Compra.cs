using Dominio.InterfaceDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra:ICompra
    {
        public int IdCompra { get; set; }
        public Usuario usuario { get; set; }
        public Proveedor proveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NuemroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
