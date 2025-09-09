using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class UserDTOWrite
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string PhoneNumber { get; set; } = "";
    }
}
