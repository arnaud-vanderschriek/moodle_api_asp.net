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
        public int ID { get; set; }
        public int AssessmentID { get; set; }
        public int UserID { get; set; }
        public int Score { get; set; }

        public virtual Assessment Assessment { get; set; }  = null!;

        public virtual Users User { get; set; } = null!;
    }
}
