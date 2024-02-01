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
    public class LoginRepository : BaseRepository<Login>, ILoginRepository
    {
        public LoginRepository(MoodleContext context) : base(context) { }

        public Login? Get(string email)
        {
            return _table.FirstOrDefault(l => l.Email == email);
        }
    }
}
