using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class ProductDTOAdminWrite
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Sku { get; set; }
        [Required]
        public int StockQuantity { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
    }
}
