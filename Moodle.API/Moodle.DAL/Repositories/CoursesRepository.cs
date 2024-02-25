using Be.KhunLy.EF.Repository;
using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.DAL.Repositories
{
    public class CoursesRepository : BaseRepository<Courses>, ICoursesRepository
    {
        public CoursesRepository(MoodleContext context) : base(context) { }


        public List<Courses> GetCoursesByUserId(int cursusId)
        {
            return _table.Where(e => e.Id == cursusId).ToList();
        }

        public List<Courses> FindAllByUserId(int userId)
        {
            return _table.Where(e => e.Id == userId).ToList();
        }
        
    }
}
