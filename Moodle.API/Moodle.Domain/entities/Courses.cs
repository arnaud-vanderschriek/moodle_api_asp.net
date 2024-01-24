using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Courses")]
    public class Courses
    {
        public int ID { get; set; }
        public string CourseName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int UserID { get; set; }

        public virtual ICollection<Module> Modules { get; set; } = null!;
        public virtual ICollection<Assessment> Assessments { get; set; } = null!;
      
    }
}
