﻿using Moodle.BLL.Infrastructure;
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

        public static IEnumerable<Users> InitUsers()
        {
            yield return new Users() { Id = 1, UserName = "Arnaud", Password = salt.Hash("ArnaudHebentoi24")    , Email = "arnaud.vanderschrieck@gmail.com", RoleID = 1 };
        }

        public static IEnumerable<Roles> InitRoles()
        {
            yield return new Roles() { ID = 1, RoleName = "student", Description = "eleve" };
        }
        
        public static IEnumerable<Courses> InitCourses()
        {
            yield return new Courses() { Id = 1, Name = "ASP.NET", Description = "programmation web en c#", UserID = 1, StartDate = DateTime.Now, EndDate = DateTime.Today }; 
        }

    }
}
