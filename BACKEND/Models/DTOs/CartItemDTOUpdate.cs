using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class CartItemDTOUpdate
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
