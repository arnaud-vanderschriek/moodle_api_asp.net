using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moodle.Domain.entities
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int RoleID { get; set; }


        [ForeignKey("RoleID")]
        public Roles Roles { get; set; } = null!;

  
        public ICollection<UserCourse>? UserCourse { get; set; }   
        public ICollection<AssessmentResult>? AssessmentResults { get; set; } 

    }
}
