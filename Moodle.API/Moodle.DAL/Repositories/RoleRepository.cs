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

        public Roles? getRolesById(int userId)
        {
            return _table
                .FirstOrDefault(r => r.ID == userId);
                            
        }
        
        public Roles? getRolesByName(string roleName)
        {
            return _table
                .FirstOrDefault(r => r.RoleName == roleName);
        }
         // Roles GetRoleByName(string roleName);
         // void CreateRole(Roles role);
         // void UpdateRole(Roles role);
         // void DeleteRole(int roleId);




        // Voir une liste de cours.

        // M'inscrire a un cours.
        // Voir les modules de ce cours (module est lié a un cours).
        // Voir la date du controle lié a la fin d'un module.
        // Voir ma courbe d'apprentissage en fonction des controles passés.
        // Voir mes résultats.


    }
}
