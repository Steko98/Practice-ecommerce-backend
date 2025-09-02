namespace BACKEND.Models
{
    /// <summary>
    /// Represents a connection between the order and the product
    /// </summary>
    public class ProductOrder : Entity
    {
        /// <summary>
        /// Gets or sets the identifier of the product placed in the order
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// Gets or sets the price of the product placed in the order
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the quantity of the products placed in the order
        /// </summary>
        public int Quantity { get; set; }
    }
}
