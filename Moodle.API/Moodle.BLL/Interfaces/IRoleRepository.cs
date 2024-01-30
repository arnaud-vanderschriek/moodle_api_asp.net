using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface IRoleRepository
    {
        Roles? GetRoleById(int userId);
        Roles? GetRoleByName(string roleName);
        void CreateRole(Roles role);
        void UpdateRole(Roles role);
        void DeleteRole(int roleId);
    }
}
