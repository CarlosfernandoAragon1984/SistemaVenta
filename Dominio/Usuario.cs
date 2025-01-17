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
        [DisplayName("Rol")]
        public Rol rol { get; set; }
        //
        public int IdUsuario { get; set; }
        //
        public string Clave { get; set; }
        //
        [DisplayName("Estado")]
        public bool Estado { get; set; }
        //
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        //
        [DisplayName("Correo")]
        public string Email { get; set; }
       //
        [DisplayName("Documento")]
        public string Documento { get; set; }
       //
        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; }
       //
        public DateTime FechaRegistro { get; set; }
       
  
       
      
       
       
        
       
    }
}
