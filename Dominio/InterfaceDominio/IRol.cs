using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IRol
    {
        int IdRol { get; set; }
        string Descripcion { get; set; }
        DateTime FechaRegistro { get; set; }
    }
}
