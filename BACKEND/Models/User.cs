namespace BACKEND.Models
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        public string Email { get; set; } = "";

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        public string Password { get; set; } = "";

        /// <summary>
        /// Gets or sets the user's phone number.
        /// </summary>
        public string? PhoneNumber { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Cart> Carts { get; set; }

    }
}
