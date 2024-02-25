using D = Moodle.Domain.entities;

namespace Moodle.API.DTO.Cursus
{
    public class CursusDTO
    {
        public CursusDTO(D.Cursus c)
        {
            Id = c.Id;
            Name = c.Name;
            StartDate = c.startDate;
            EndDate = c.endDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
