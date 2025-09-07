using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class PaymentDTOWrite
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        [MaxLength(100)]
        public string PayMethod { get; set; }
    }
}
