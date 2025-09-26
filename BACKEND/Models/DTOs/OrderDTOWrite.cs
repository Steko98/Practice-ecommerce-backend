using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class OrderDTOWrite
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public List<int> ProductIds { get; set; } = [];
    }
}
