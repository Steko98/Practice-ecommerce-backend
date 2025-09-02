namespace BACKEND.Models
{
    /// <summary>
    /// Represents a shopping cart entry for a user and product.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Gets or sets the user identifier associated with the cart entry.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the product identifier in the cart.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}
