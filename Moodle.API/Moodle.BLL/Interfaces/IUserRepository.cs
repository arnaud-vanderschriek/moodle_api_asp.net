using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Interfaces
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        Users? GetUserById(int userId);
       // Users? GetUserByUsername(string username);
        Users CreateUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(int userId);
        IEnumerable<Users> GetUsersByRole(string roleName);




        // Voir une liste de cours.
        // M'inscrire a un cours.
        // Voir les modules de ce cours (module est lié a un cours).
        // Voir la date du controle lié a la fin d'un module.
        // Voir ma courbe d'apprentissage en fonction des controles passés.
        // Voir mes résultats. 

    }
}
