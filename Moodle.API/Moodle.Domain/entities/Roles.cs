using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Roles")]
    public class Roles
    {
        public int ID { get; set; }

        public string RoleName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public virtual ICollection<Users> Users { get; set; } = null!;
      
    }
}
