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
        private readonly MoodleContext _dbContext;
        public UserRepository(MoodleContext context) : base(context)
        {
            _dbContext = context;
         }

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

        public List<Courses> GetUserCourses(int userId)
        {
           var courses =  _dbContext.UserCourse
            .Where(uc => uc.UserId == userId)
            .Select(uc => uc.Course)
            .ToList();

            return courses;
        }

        public List<Cursus> GetCursus(int id)
        {
            var curriculums = _dbContext.UserCourse
        .Where(uc => uc.UserId == id)
        .Select(uc => uc.Course.Cursus)
        .Distinct() 
        .ToList();

            return curriculums;
        }

        public List<Module> GetModuleEndDatesForUser(int id)
        {
             var modulesForUser = _dbContext.UserCourse
            .Where(uc => uc.UserId == id)
            .SelectMany(uc => uc.Course.Modules) // SelectMany pour aplatir la liste d'ID de modules
            .Distinct()
            .ToList();

            return modulesForUser;
        }
    }
}
