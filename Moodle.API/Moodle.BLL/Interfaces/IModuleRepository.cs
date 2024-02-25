using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface IModuleRepository
    {
        List<Module> FindAll();
        List<Module> GetModulesByCourseId(int courseId);
    }
}
