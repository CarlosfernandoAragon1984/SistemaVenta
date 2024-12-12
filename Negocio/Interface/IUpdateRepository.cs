using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interface
{
    public interface IUpdateRepository<T>
    {
        bool Update(T entity, out string mensaje);
    }
}
