using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IPermiso
    {
         int IdPermiso { get; set; }
         Rol rol { get; set; }
         string NombreMenu { get; set; }
         DateTime FechaRegistro { get; set; }
    }
}
