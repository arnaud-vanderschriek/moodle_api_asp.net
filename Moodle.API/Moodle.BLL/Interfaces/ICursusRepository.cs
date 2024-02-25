using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface ICursusRepository
    {
        Cursus Find(params object[]? id);
        List<Cursus> FindAll();

        Cursus Add(Cursus cursus);
        List<Cursus> GetCursusByUserCursusId(int userId);
    }
}
