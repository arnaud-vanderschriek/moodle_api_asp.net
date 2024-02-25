using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface ICoursesRepository
    {
        List<Courses> GetCoursesByUserId(int id);
        List<Courses> FindAllByUserId(int id);
        List<Courses> FindAll();
        Courses Add(Courses courses);
    }
}
