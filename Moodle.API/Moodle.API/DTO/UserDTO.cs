using Moodle.Domain.entities;
using System.ComponentModel.DataAnnotations;
using D = Moodle.Domain.entities;

namespace Moodle.API.DTO
{
    public class UserDTO
    {
        public UserDTO(D.Users u) 
        {
            Id = u.Id;
            UserName = u.UserName;
            Password = u.Password;
            Email = u.Email;
            Role = u.Role;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; } = null!;
        public string Email { get; set; }
        public Roles Role {  get; set; }    
    }
}
