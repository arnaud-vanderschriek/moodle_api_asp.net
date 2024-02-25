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
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Deadline { get; set; }

        public int ModuleId { get; set; }
        [ForeignKey("ModuleId")]
        public Module Module { get; set; }  = null!;

        public ICollection<AssessmentResult>? AssessmentResults { get; set; } // Relation avec AssessmentResult

    }
}
