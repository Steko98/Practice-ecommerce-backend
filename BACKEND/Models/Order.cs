namespace BACKEND.Models
{
    /// <summary>
    /// Represents an order placed by a user, including order details and associated addresses.
    /// </summary>
    public class Order : Entity
    {
        /// <summary>
        /// Gets or sets the identifier of the user who placed the order.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the total amount for the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        public string OrderStatus { get; set; } = "";

        /// <summary>
        /// Gets or sets the date and time when the order was placed.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the shipping address for the order.
        /// </summary>
        public int ShippingAddressId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the billing address for the order.
        /// </summary>
        public int BillingAddressId { get; set; }
    }
}
