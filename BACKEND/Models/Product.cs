namespace BACKEND.Models
{
    /// <summary>
    /// Represents a product in the system.
    /// </summary>
    public class Product : Entity
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the SKU (Stock Keeping Unit) of the product.
        /// </summary>
        public string Sku { get; set; } = "";

        /// <summary>
        /// Gets or sets the quantity of the product in stock.
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the product.
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// Gets or sets the identifier of the product category
        /// </summary>
        public int CategoryId { get; set; }
    }
}
