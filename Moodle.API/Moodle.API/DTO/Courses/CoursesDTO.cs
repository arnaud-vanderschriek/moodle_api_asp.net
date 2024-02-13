
using D = Moodle.Domain.entities;

namespace Moodle.API.DTO.Courses
{
    public class CoursesDTO
    {
        public CoursesDTO(D.Courses c)
        {
            Id = c.Id;
            Name = c.Name;
            Descripton = c.Description;
            StartDate = c.StartDate;
            EndDate = c.EndDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
