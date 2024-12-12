using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InterfaceDominio
{
    public interface IUsuario
    {
        int IdUsuario { get; set; }
        string Documento { get; set; }
        string NombreCompleto { get; set; }
        string Email { get; set; }
        string Clave { get; set; }
        bool Estado { get; set; }
        Rol rol { get; set; }
        DateTime FechaRegistro { get; set; }
    }
}
