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
    public class RoleRepository : BaseRepository<Roles>, IRoleRepository
    {
        public RoleRepository(MoodleContext context) : base(context)
        {

        }

        public Roles? GetRoleById(int userId)
        {
            return _table
                .FirstOrDefault(r => r.ID == userId);               
        }
        
        public Roles? GetRoleByName(string roleName)
        {
            return _table
                .FirstOrDefault(r => r.RoleName == roleName);
        }

        public void CreateRole(Roles role)
        {

        }

        public void UpdateRole(Roles role)
        {

        }
        public void DeleteRole(int roleId)
        {

        }
    }
}
