using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface ICategoria
    {
         int IdCategoria { get; set; }
         string Descripcion { get; set; }
         bool Estado { get; set; }
         DateTime FechaRegistro { get; set; }
    }
}
