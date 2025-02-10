using Dominio;
using Negocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service.UserService
{
    public class UpdateUserService
    {
        /*¿Qué es la inyección de dependencias?*/
        /* 3) Constructor: En el constructor de la
         * clase que necesita la dependencia, se recibe
         * como parámetro un objeto que implementa la interfaz.*/
      
        private readonly IUpdateRepository<Usuario> _users;
        public UpdateUserService(IUpdateRepository<Usuario> users)
        {
            _users = users;
        }
        public  void Update(Usuario usuario) {  _users.Update(usuario); }
    }

}

