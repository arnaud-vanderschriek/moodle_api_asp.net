using Moodle.BLL.Infrastructure;
using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Services
{
    public class UserService(
        IUserRepository _userRepository, 
        ICursusRepository _cursusRepository, 
        ICoursesRepository _coursesRepository,
        IModuleRepository _moduleRepository
        )
    {
        public List<Users> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Users? GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public Users AddUser(string username,byte[] password, string email, Roles role) 
        {

            return _userRepository.CreateUser(new Users
            {
                UserName = username,
                Password = password,
                Email = email, 
                Roles = role
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

        public List<Courses> GetUserWithCourses(int id)
        {

            List<Courses> courses = _userRepository.GetUserCourses(id);

            if (courses == null)
            {
                throw new KeyNotFoundException();
            }
            return courses;

        }

        public List<Cursus> GetCursusOfUser(int id)
        {
            List<Cursus> cursus = _userRepository.GetCursus(id);
            if (cursus == null) 
            {
                throw new KeyNotFoundException();
            } 

            return cursus;
        }

        public List<Module> GetModuleEndDatesForUser(int id)
        {
            List<Module> modulesEndDate = _userRepository.GetModuleEndDatesForUser(id);

            if(modulesEndDate == null)
            {
                throw new KeyNotFoundException();
            }
            return modulesEndDate; 
        }

    }
}
