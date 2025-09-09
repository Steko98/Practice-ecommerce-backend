using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class ProductOrderDTOWrite
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
