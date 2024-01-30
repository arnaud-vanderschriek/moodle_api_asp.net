using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Services
{
    public class UserService(IUserRepository _userRepository)
    {
        public List<Users> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Users? GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public Users AddUser(string username, string email, Roles role) 
        {
            return _userRepository.CreateUser(new Users
            {
                UserName = username,
                Email = email, 
                Role = role
            });

        }

        public void DeleteUser(int id) 
        { 
           // Users user = _userRepository.DeleteUser(id); // C'est içi que je dois vérifier si j'ai différente Business logique
          /*  if(user is null)
            {
                throw new KeyNotFoundException();
            }*/
        }
    }
}
