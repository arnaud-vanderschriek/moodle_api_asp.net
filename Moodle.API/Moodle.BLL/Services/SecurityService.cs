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
     public class SecurityService(ILoginRepository _loginRepository, IPasswordHasher _passwordHasher)
    {
        public Login Login(string email, string password)
        {
            Login? l = _loginRepository.Get(email);
            if(l == null)
            {
                throw new ValidationException("Aucun user avec cet email");
            }
            if(!_passwordHasher.Hash(l.Email + password).SequenceEqual(l.Password))
            {
                throw new ValidationException("password non valid");
            }

            return l;
        }
    }
}
