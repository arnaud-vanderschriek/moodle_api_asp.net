using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moodle.Domain.entities
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int RoleID { get; set; }

        public int CursusId { get; set; }

        [ForeignKey("RoleID")]
        public Roles Roles { get; set; } = null!;

        [ForeignKey("CursusId")]
        public Cursus Cursus { get; set; } = null!;  

    }
}
