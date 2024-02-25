using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Cursus")]
    public class Cursus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public byte[]? images { get; set; }

        public ICollection<Courses>? Courses { get; set; } 

    }
}
