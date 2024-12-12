using Dominio.InterfaceDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Permiso:IPermiso
    {
        public int IdPermiso { get; set; }
        public Rol rol { get; set; }
        public string NombreMenu { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
