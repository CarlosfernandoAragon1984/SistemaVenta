using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario usuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NuemroDocumento { get; set; }
        public string ClienteDocumento { get; set; }
        public string ClienteNombre { get; set; }
        public decimal Pago { get; set; }
        public decimal Cambio { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> DetalleVenta { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
