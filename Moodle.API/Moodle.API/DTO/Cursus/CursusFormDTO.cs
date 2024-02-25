namespace Moodle.API.DTO.Cursus
{
    public class CursusFormDTO
    {
        public string Name { get; set; } = null!;

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
