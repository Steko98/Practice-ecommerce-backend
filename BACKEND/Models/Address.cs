namespace BACKEND.Models
{
    /// <summary>
    /// Represents a user's address information.
    /// </summary>
    public class Address : Entity
    {
        /// <summary>
        /// Gets or sets the identifier of the user associated with this address.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the first line of the address.
        /// </summary>
        public string AddressLine1 { get; set; } = "";

        /// <summary>
        /// Gets or sets the optional second line of the address.
        /// </summary>
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the city of the address.
        /// </summary>
        public string City { get; set; } = "";

        /// <summary>
        /// Gets or sets the postal code of the address.
        /// </summary>
        public string PostalCode { get; set; } = "";

        /// <summary>
        /// Gets or sets the country of the address.
        /// </summary>
        public string Country { get; set; } = "";

        /// <summary>
        /// Gets or sets the type of the address (e.g., Home, Work).
        /// </summary>
        public string AddressType { get; set; } = "";
    }
}
