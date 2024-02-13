namespace Moodle.API.DTO.Courses
{
    public class CoursesFormDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
