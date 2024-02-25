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

        public static IEnumerable<UserCourse> InitUserCourses()
        {
            yield return new UserCourse() {Id = 1, UserId = 1, CourseId = 1 };
            yield return new UserCourse() {Id = 2, UserId = 2, CourseId = 2 };
            yield return new UserCourse() {Id = 3, UserId = 3, CourseId = 1 };
            yield return new UserCourse() {Id = 4, UserId = 1, CourseId = 8 };
            yield return new UserCourse() {Id = 5, UserId = 2, CourseId = 4 };
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

            yield return new Users()
            {
                Id = 1,
                UserName = "Arnaud",
                Password = salt.Hash("ArnaudHebentoi24"),
                Email = "arnaud.vanderschrieck@gmail.com",
                RoleID = 1,  
            };
            yield return new Users() { Id = 2, UserName = "Yanis", Password = salt.Hash("Yanis1234"), Email = "yanis.oykonomou@gmail.com", RoleID = 1 };
            yield return new Users() { Id = 3, UserName = "Padraig", Password = salt.Hash("Padraig1234"), Email = "padraig.kisembe@gmail.com", RoleID = 1 };
            yield return new Users() { Id = 4, UserName = "Hamza", Password = salt.Hash("Hamza1234"), Email = "hamza.tsebien@gmail.com", RoleID = 1 }; 

            yield return new Users() { Id = 5, UserName = "Dumbledore", Password = salt.Hash("dumb1234"), Email = "dumb.ledore@gmail.com", RoleID = 2 };  
            yield return new Users() { Id = 6, UserName = "Cloud", Password = salt.Hash("cloud1234"), Email = "cloud.strife@gmail.com", RoleID = 2 };
            yield return new Users() { Id = 7, UserName = "test", Password = salt.Hash("test1234"), Email = "test.test@gmail.com", RoleID = 2 };

            yield return new Users() { Id = 8, UserName = "Boss", Password = salt.Hash("Boss1234"), Email = "boss.imtheboss@gmail.com", RoleID = 3 };

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
                CursusId = 1,
            };

            yield return new Courses()
            {
                Id = 2,
                Name = "ASP.NET / Cours 2",
                Description = "ASP.NET advanced",
                StartDate = new DateTime(2024, 1, 3),
                EndDate = new DateTime(2024, 3, 26),
                CursusId = 1

            };

            yield return new Courses()
            {
                Id = 3,
                Name = "ASP.NET / Cours 3",
                Description = "ASP.NET confirmed",
                StartDate = new DateTime(2024, 3, 27),
                EndDate = new DateTime(2024, 6, 28),
                CursusId = 1
            };

            //////////////////////////////////// Javscript 1,2,3
            yield return new Courses()
            {
                Id = 4,
                Name = "Javascript / Cours 1",
                Description = "Javascript beginner",
                StartDate = new DateTime(2023, 9, 5),
                EndDate = new DateTime(2023, 12, 22),
                CursusId = 2
            };

            yield return new Courses()
            {
                Id = 5,
                Name = "Javascript / Cours 2",
                Description = "Javascript advanced",
                StartDate = new DateTime(2024, 1, 5),
                EndDate = new DateTime(2024, 3, 28),
                CursusId = 2
            };

            yield return new Courses()
            {
                Id = 6,
                Name = "Javascript / Cours 3",
                Description = "Javascript confirmed",
                StartDate = new DateTime(2024, 4, 5),
                EndDate = new DateTime(2024, 6, 28),
                CursusId = 2
            };
            ////////////////////////////////////// React Courses 1,2,3
            ///
            yield return new Courses()
            {
                Id = 7,
                Name = "React / Cours 1",
                Description = "React beginner",
                StartDate = new DateTime(2024, 4, 5),
                EndDate = new DateTime(2024, 6, 28),
                CursusId = 4
            }; yield return new Courses()
            {
                Id = 8,
                Name = "React / Cours 2",
                Description = "React advanced",
                StartDate = new DateTime(2024, 4, 5),
                EndDate = new DateTime(2024, 6, 28),
                CursusId = 4
            }; yield return new Courses()
            {
                Id = 9,
                Name = "React / Cours 3",
                Description = "React confirmed",
                StartDate = new DateTime(2024, 4, 5),
                EndDate = new DateTime(2024, 6, 28),
                CursusId = 4
            };
        }

        /////////// Modules ASP.NET

        public static IEnumerable<Module> InitModules()
        {
            // 8/9/2023 => 26/12/2023
            yield return new Module()
            {
                Id = 1,
                Name = "ASP.NET cours 1 / module 1",
                StartDate = new DateTime(2023, 9, 8),
                EndDate = new DateTime(2023, 10, 12),
                CourseId = 1
            };

            yield return new Module()
            {
                Id = 2,
                Name = "ASP.NET cours 1 / module 2",
                StartDate = new DateTime(2023, 10, 16),
                EndDate = new DateTime(2023, 11, 3),
                CourseId = 1
            };

            yield return new Module()
            {
                Id = 3,
                Name = "ASP.NET cours 1 / module 3",
                StartDate = new DateTime(2023, 11, 6),
                EndDate = new DateTime(2023, 12, 26),
                CourseId = 1

            };

            /////////////////////////////////////////////////////////

            yield return new Module()
            {
                Id = 4,
                Name = "ASP.NET cours 2 / module 1",
                StartDate = new DateTime(2024, 1, 3),
                EndDate = new DateTime(2024, 1, 31),
                CourseId = 2

            };
            yield return new Module()
            {
                Id = 5,
                Name = "ASP.NET cours 2 / module 2",
                StartDate = new DateTime(2024, 2, 5),
                EndDate = new DateTime(2024, 2, 29),
                CourseId = 2

            };

            yield return new Module()
            {
                Id = 6,
                Name = "ASP.NET cours 2 / module 3",
                StartDate = new DateTime(2024, 3, 4),
                EndDate = new DateTime(2024, 3, 26),
                CourseId = 2

            };

            ////////////////////////////////////////////////////////
    
            yield return new Module()
            {
                Id = 7,
                Name = "ASP.NET cours 3 / module 1",
                StartDate = new DateTime(2024, 3, 27),
                EndDate = new DateTime(2024, 4, 17),
                CourseId = 3

            }; 
            
            yield return new Module()
            {
                Id = 8,
                Name = "ASP.NET cours 3 / module 2",
                StartDate = new DateTime(2024, 4, 22),
                EndDate = new DateTime(2024, 5, 24),
                CourseId = 3
            }; 
            
            yield return new Module()
            {
                Id = 9,
                Name = "ASP.NET cours 3 / module 3",
                StartDate = new DateTime(2024, 5, 27),
                EndDate = new DateTime(2024, 6, 28),
                CourseId = 3
            };

            ///////////////////////////////////////
/*            StartDate = new DateTime(2024, 4, 5),
                EndDate = new DateTime(2024, 6, 28),*/
            yield return new Module()
            {
                Id = 10,
                Name = "React cours 2 / module 1",
                StartDate = new DateTime(2024, 4, 5),
                EndDate = new DateTime(2024, 4, 25),
                CourseId = 8
            };

            yield return new Module()
            {
                Id = 11,
                Name = "React cours 2 / module 2",
                StartDate = new DateTime(2024, 5, 6),
                EndDate = new DateTime(2024, 6, 28),
                CourseId = 8
            };
        }
    }
}
