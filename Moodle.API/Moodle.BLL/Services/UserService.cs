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

        public void Delete(int id) 
        {
            _userRepository.DeleteUser(id);
        }


        public void UpdateUser(int id, string username, string email) 
        {

            Users? user = _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new KeyNotFoundException();
            }
            user.Email = email;
            user.UserName = username;
            _userRepository.UpdateUser(user);
        }
    }
}
