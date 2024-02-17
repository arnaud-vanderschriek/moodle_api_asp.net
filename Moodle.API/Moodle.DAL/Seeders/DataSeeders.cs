using Moodle.BLL.Infrastructure;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.DAL.Seeders
{
    public static class DataSeeders
    {
        static PasswordHasher salt = new PasswordHasher();

        public static IEnumerable<Roles> InitRoles()
        {
            yield return new Roles() { Id = 1, RoleName = "student", Description = "student" };
            yield return new Roles() { Id = 2, RoleName = "teacher", Description = "teacher" };
            yield return new Roles() { Id = 3, RoleName = "admin", Description = "admin" };
        }

        public static IEnumerable<Cursus> InitCursus()
        {
            yield return new Cursus()
            {
                Id = 1,
                Name = "ASP.NET",
                startDate = new DateTime(2023, 9, 8),
                endDate = new DateTime(2024, 6, 28),
            };
            yield return new Cursus() { Id = 2, Name = "Javascript", startDate = new DateTime(2023, 9, 8), endDate = new DateTime(2024, 6, 28) };
            yield return new Cursus() { Id = 3, Name = "Python", startDate = new DateTime(2023, 9, 8), endDate = new DateTime(2024, 6, 28) };
            yield return new Cursus() { Id = 4, Name = "React", startDate = new DateTime(2023, 9, 8), endDate = new DateTime(2024, 6, 28) };
            yield return new Cursus() { Id = 5, Name = "Angular", startDate = new DateTime(2023, 9, 8), endDate = new DateTime(2024, 6, 28) };
            yield return new Cursus() { Id = 6, Name = "Designer", startDate = new DateTime(2023, 9, 8), endDate = new DateTime(2024, 6, 28) };
        }

        public static IEnumerable<Users> InitUsers()
        {
            yield return new Users() { Id = 1, UserName = "Arnaud", Password = salt.Hash("ArnaudHebentoi24"), Email = "arnaud.vanderschrieck@gmail.com", RoleID = 1, CursusId = 1 };
            yield return new Users() { Id = 2, UserName = "Yanis", Password = salt.Hash("Yanis1234"), Email = "yanis.oykonomou@gmail.com", RoleID = 1, CursusId =  2};
            yield return new Users() { Id = 3, UserName = "Padraig", Password = salt.Hash("Padraig1234"), Email = "padraig.kisembe@gmail.com", RoleID = 1, CursusId = 3 };
            yield return new Users() { Id = 4, UserName = "Hamza", Password = salt.Hash("Hamza1234"), Email = "hamza.tsebien@gmail.com", RoleID = 1, CursusId = 4 };

            yield return new Users() { Id = 5, UserName = "Dumbledore", Password = salt.Hash("dumb1234"), Email = "dumb.ledore@gmail.com", RoleID = 2, CursusId = 1 };
            yield return new Users() { Id = 6, UserName = "Cloud", Password = salt.Hash("cloud1234"), Email = "cloud.strife@gmail.com", RoleID = 2, CursusId = 2 };
            yield return new Users() { Id = 7, UserName = "test", Password = salt.Hash("test1234"), Email = "test.test@gmail.com", RoleID = 2, CursusId = 3 };

            yield return new Users() { Id = 8, UserName = "Boss", Password = salt.Hash("Boss1234"), Email = "boss.imtheboss@gmail.com", RoleID = 3, CursusId = 4 };

        }
     

     

        public static IEnumerable<Courses> InitCourses()
        {
            yield return new Courses()
            {
                Id = 1,
                Name = "ASP.NET / Cours 1",
                Description = "ASP.NET beginner",
                StartDate = new DateTime(2023, 9, 8),
                EndDate = new DateTime(2023, 12, 26),
                UserID = 3,
                CursusId = 1,
            };

            yield return new Courses()
            {
                Id = 2,
                Name = "ASP.NET / Cours 2",
                Description = "ASP.NET advanced",
                StartDate = new DateTime(2024, 1, 3),
                EndDate = new DateTime(2024, 3, 26),
                UserID = 1 ,
                CursusId = 1

            };

            yield return new Courses()
            {
                Id = 3,
                Name = "ASP.NET / Cours 3",
                Description = "ASP.NET confirmed",
                StartDate = new DateTime(2024, 3, 27),
                EndDate = new DateTime(2024, 6, 28),
                UserID = 1,
                CursusId = 1
            };
        }

        public static IEnumerable<Module> InitModules()
        {
            // 8/9/2023 => 26/12/2023
            yield return new Module()
            {
                Id = 1,
                name = "ASP.NET cours 1 / module 1",
                startDate = new DateTime(2023, 9, 8),
                endDate = new DateTime(2023, 10, 12),
                CourseId = 1
            };

            yield return new Module()
            {
                Id = 2,
                name = "ASP.NET cours 1 / module 2",
                startDate = new DateTime(2023, 10, 16),
                endDate = new DateTime(2023, 11, 3),
                CourseId = 1
            };

            yield return new Module()
            {
                Id = 3,
                name = "ASP.NET cours 1 / module 3",
                startDate = new DateTime(2023, 11, 6),
                endDate = new DateTime(2023, 12, 26),
                CourseId = 1

            };

            /////////////////////////////////////////////////////////
            // 3/1/2024 => 26/3/2024

            yield return new Module()
            {
                Id = 4,
                name = "ASP.NET cours 2 / module 1",
                startDate = new DateTime(2024, 1, 3),
                endDate = new DateTime(2024, 1, 31),
                CourseId = 2

            };
            yield return new Module()
            {
                Id = 5,
                name = "ASP.NET cours 2 / module 2",
                startDate = new DateTime(2024, 2, 5),
                endDate = new DateTime(2024, 2, 29),
                CourseId = 2

            };

            yield return new Module()
            {
                Id = 6,
                name = "ASP.NET cours 2 / module 3",
                startDate = new DateTime(2024, 3, 4),
                endDate = new DateTime(2024, 3, 26),
                CourseId = 2

            };

            ////////////////////////////////////////////////////////
            // 27/3/2024 => 28/6/2024
    
            yield return new Module()
            {
                Id = 7,
                name = "ASP.NET cours 3 / module 1",
                startDate = new DateTime(2024, 3, 27),
                endDate = new DateTime(2024, 4, 17),
                CourseId = 3

            }; 
            
            yield return new Module()
            {
                Id = 8,
                name = "ASP.NET cours 3 / module 2",
                startDate = new DateTime(2024, 4, 22),
                endDate = new DateTime(2024, 5, 24),
                CourseId = 3
            }; 
            
            yield return new Module()
            {
                Id = 9,
                name = "ASP.NET cours 3 / module 3",
                startDate = new DateTime(2024, 5, 27),
                endDate = new DateTime(2024, 6, 28),
                CourseId = 3
            };

        }
    }
}
