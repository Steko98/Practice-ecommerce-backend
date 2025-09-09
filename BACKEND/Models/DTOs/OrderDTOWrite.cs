using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class OrderDTOWrite
    {
        [Required]
        public int ShippingAddressId { get; set; }
        [Required]
        public int BillingAddresId { get; set; }
        [Required]
        public List<int> ProductIds { get; set; } = new();
    }
}
