﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("LearningProgress")]
    public class LearningProgress
    {
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int? CourseID { get; set; }
        public int? ModuleID { get; set; }
        public int? LessonID { get; set; }
        public DateTime? Timestamp { get; set; }

        public Users? User { get; set; }  = null!;
        public Courses? Course { get; set; }  = null!;
        public Module? Module { get; set; }  = null!;
        public Lesson? Lesson { get; set; }  = null!;
    }
}
