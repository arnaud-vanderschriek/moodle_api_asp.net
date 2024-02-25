using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Module")]
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }   

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Courses Course { get; set; } = null!;

        public ICollection<Assessment>? Assessments { get; set; } // Relation avec Assessment
    }
}
