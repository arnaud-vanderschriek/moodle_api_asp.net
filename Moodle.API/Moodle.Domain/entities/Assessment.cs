using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Assessment")]
    public class Assessment
    {
        public int ID { get; set; }
        public string AssessmentName { get; set; } = null!;
        public int CourseID { get; set; }
        public DateTime Deadline { get; set; }

        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }  = null!;

        public virtual Courses Course { get; set; }  = null!;

    }
}
