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
    public class ModuleRepository: BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(MoodleContext context) : base(context) { }

        public override List<Module> FindAll()
        {
            return base.FindAll();
        }

        public List<Module> GetModulesByCourseId(int coursesId) 
        {
            return _table.Where(e => e.CourseId == coursesId).ToList();
        }
    }
}
