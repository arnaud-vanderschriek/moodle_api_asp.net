using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Lesson")]
    public class Lesson
    {
        public int ID { get; set; }
        public string LessonName { get; set; }  = null!;

        public int ModuleID { get; set; }
        public string Content { get; set; }  = null!;

        public virtual Module Module { get; set; }  = null!;

        public virtual ICollection<LearningProgress> LearningProgress { get; set; }  = null!;

    }
}
