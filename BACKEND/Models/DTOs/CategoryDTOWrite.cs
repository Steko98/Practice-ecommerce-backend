using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class CategoryDTOWrite
    {
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
