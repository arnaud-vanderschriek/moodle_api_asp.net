using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        Users? GetUserById(int userId);
       // Users? GetUserByUsername(string username);
        Users CreateUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(int userId);
        IEnumerable<Users> GetUsersByRole(string roleName);
    }
}
