using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class CartProductDTOWrite
    {
        [Required]
        public int CartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
    }
}
