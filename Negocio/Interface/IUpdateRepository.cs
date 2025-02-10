using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interface
{
    public interface IUpdateRepository<T>
    {
        /*¿Qué es la inyección de dependencias?*/
        /* 1) Interfaces: Se define una interfaz
         * que representa la dependencia*/
        void Update(T entity);
    }
}
