using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class AddressDTOWrite
    {
        [Required]
        [MaxLength(255)]
        public string AddressLine1 { get; set; }
        [MaxLength(255)]
        public string AddressLine2 { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        public AddressType AddressType { get; set; }
    }
}
