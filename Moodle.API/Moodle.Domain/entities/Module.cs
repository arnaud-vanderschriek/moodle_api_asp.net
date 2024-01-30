using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Modules")]
    public class Module
    {
        public int ID { get; set; }
        public string ModuleName { get; set; } = null!;
        public int CourseID { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = null!;
        public Courses Course { get; set; } = null!;
    }
}
