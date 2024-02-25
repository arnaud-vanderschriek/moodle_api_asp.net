﻿using Microsoft.EntityFrameworkCore;
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

        public int CursusId { get; set; }
        [ForeignKey("CursusId")]
        public Cursus Cursus { get; set; } = null!;


        public ICollection<UserCourse>? UserCourses { get; set; }
        public ICollection<Module>? Modules { get; set; }

    }   
}
