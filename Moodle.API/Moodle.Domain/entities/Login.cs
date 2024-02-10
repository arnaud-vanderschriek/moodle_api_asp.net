using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Domain.entities
{
    [Table("Logins")]
    public abstract class Login
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required byte[] Password { get; set; }
        //public abstract string Role { get; }
    }
}
