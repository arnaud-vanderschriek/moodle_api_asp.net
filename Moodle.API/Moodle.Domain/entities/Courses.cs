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
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime StartDate {  get; set; }
        public DateTime EndDate {  get; set; }

        public int? UserID { get; set; }

        public Users User { get; set; } = null!;
        public ICollection<LearningProgress> LearningProgress { get; set; } = null!;
        public ICollection<Module> Modules { get; set; } = null!;
        public ICollection<Assessment> Assessments { get; set; } = null!;
    }
}
