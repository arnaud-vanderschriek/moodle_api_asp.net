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

        public Roles Role { get; set; } = null!;
        public ICollection<Courses> Courses { get; set; } = null!;  // !!! Attention rajouté après la migration
        public ICollection<AssessmentResult> AssessmentResults { get; set; } = null!;
        public ICollection<LearningProgress> LearningProgress { get; set; } = null!;

    }
}
