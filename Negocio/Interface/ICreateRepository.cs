using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interface
{
    public interface ICreateRepository<T>
    {
        int Create(T entity, out string msn);
    }
}
