using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class UserDTOLogin
    {
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
