namespace BACKEND.Models
{
    /// <summary>
    /// Represents a shopping cart entry for a user and product.
    /// </summary>
    public class Cart : Entity
    {
        /// <summary>
        /// Gets or sets the user identifier associated with the cart entry.
        /// </summary>
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<CartProduct> CartProducts { get; set; } = new List<CartProduct>();
    }
}
