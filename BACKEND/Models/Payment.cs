namespace BACKEND.Models
{
    /// <summary>
    /// Represents payment od the user
    /// </summary>
    public class Payment : Entity
    {
        /// <summary>
        /// Gets or sets the user identifier
        /// </summary>
        public int UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// Gets or sets the order identifier of the payment
        /// </summary>
        public int OrderId { get; set; }
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the payment method of the user
        /// </summary>
        public string PayMethod { get; set; } = "";
        /// <summary>
        /// Gets or sets the total price of the payment
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// Gets or sets the payment status
        /// </summary>
        public string PaymentStatus { get; set; } = "";
        /// <summary>
        /// Gets or sets date of the payment
        /// </summary>
        public DateTime PaymentDate { get; set; }
    }
}
