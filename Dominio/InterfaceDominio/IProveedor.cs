using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IProveedor
    {
         int IdProveedor { get; set; }
         string Documento { get; set; }
         string RazonSocial { get; set; }
         string Correo { get; set; }
         string Telefono { get; set; }
         bool Estado { get; set; }
         DateTime FechaRegistro { get; set; }
    }
}
