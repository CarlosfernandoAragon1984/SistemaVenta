using Dominio.InterfaceDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario:IUsuario
    {
       
        public int IdUsuario { get; set; }
       
        [DisplayName("Documento")]
        public string Documento { get; set; }
        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; }
        [DisplayName("Email")]
       
        public string Email { get; set; }
        public string Clave { get; set; }
  
       
        [DisplayName("Estado")]
        public bool Estado { get; set; }
        [DisplayName("Rol")]
        public Rol rol { get; set; }
       
        public DateTime FechaRegistro { get; set; }
    }
}
