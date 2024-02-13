using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Services
{
    public class CoursesService(ICoursesRepository _coursesRepository)
    {
        public List<Courses> GetAll()
        {
           return  _coursesRepository.GetAll();
        }
    }
}
