using Be.KhunLy.EF.Repository;
using Microsoft.EntityFrameworkCore;
using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.DAL.Repositories
{
    public class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(MoodleContext context) : base(context) { }

        public List<Users> GetAllUsers() =>  _table.ToList();
        
        public Users? GetUserById(int userId) => _table.Find(userId);

         public Users? GetUserByUsername(string username) => _table.SingleOrDefault(u => u.UserName == username);

        public Users CreateUser(Users user)
        {
            _table.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void UpdateUser(Users user)
        {
            _table.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _table.Find(userId);
            if (user != null)
            {
                _table.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Users> GetUsersByRole(string roleName)
        {
            return _table
                .Where(u => u.Roles.RoleName == roleName)
                .ToList();
        } 

            
    }
}
