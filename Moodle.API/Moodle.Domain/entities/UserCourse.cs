using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("UserCourse")]
    public class UserCourse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Courses Course { get; set; }

    }
}
