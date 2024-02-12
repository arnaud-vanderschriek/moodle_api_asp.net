using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Services
{
     public class SecurityService(IUserRepository _userRepository, IPasswordHasher _passwordHasher)
    {
        public Users Login(string username, string password)
        {
            Users? u = _userRepository.GetUserByUsername(username);
            if(u == null)
            {
                throw new ValidationException("Aucun user avec cet identifiant");
            }
            if(!_passwordHasher.Hash(u.UserName + password).SequenceEqual(u.Password))
            {
                throw new ValidationException("password non valid");
            }

            return u;
        }
    }
}
