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
        public string name { get; set; } = null!;

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }   

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Courses Course { get; set; } = null!;

    }
}
