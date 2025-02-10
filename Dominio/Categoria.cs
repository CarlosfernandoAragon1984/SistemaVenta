using Dominio.InterfaceDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria:ICategoria
    {
        /* Orden de las propiedades en la clase:  este es un factor,
         * que en este caso  determina el orden final de las columnas 
         * en el dataGridView (dgvCategoria).*/
       
        public DateTime FechaRegistro { get; set; }
        
        
        [DisplayName("Estado")]
        public bool Estado { get; set; }
       
        
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
       
        
        public int IdCategoria { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
