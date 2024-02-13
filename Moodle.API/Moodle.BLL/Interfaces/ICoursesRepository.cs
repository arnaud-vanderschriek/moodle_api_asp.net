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
        List<Courses> GetAll();
        Courses Add(Courses courses);
    }
}
