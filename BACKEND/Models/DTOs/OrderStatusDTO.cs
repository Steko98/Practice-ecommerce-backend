using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class OrderStatusDTO
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public OrderStatus OrderStatus { get; set; }
    }
}
