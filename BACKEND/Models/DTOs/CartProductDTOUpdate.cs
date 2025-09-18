using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class CartProductDTOUpdate
    {
        [Required]
        public int Quantity { get; set; } = 1;
    }
}
