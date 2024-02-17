using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("AssessmentResult")]
    public class AssessmentResult
    {
        public int Id { get; set; }
        public int AssessmentId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }

        [ForeignKey("AssessmentId")]
        public Assessment Assessment { get; set; }  = null!;

        [ForeignKey("UserId")]
        public Users Users { get; set; } = null!;
    }
}
