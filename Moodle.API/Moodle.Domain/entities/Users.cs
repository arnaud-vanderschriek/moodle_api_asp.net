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
        public int ID { get; set; }

        public string UserName { get; set; } = null!;

        public byte[] Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int RoleID { get; set; }

        public virtual Roles Role { get; set; } = null!;
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; } = null!;
        public virtual ICollection<LearningProgress> LearningProgress { get; set; } = null!;

    }
}
