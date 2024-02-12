using System.ComponentModel.DataAnnotations;

namespace Moodle.API.DTO
{
    public class UserFormDTO
    {
        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        public string UserName { get; set; } = null!;

        [Required]
        [RegularExpression("^[a - zA - Z0 - 9._ % +-]+@[a - zA - Z0 - 9.-]+.[a - zA - Z]{2,}$")]
        public string Email { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;

    }
}
