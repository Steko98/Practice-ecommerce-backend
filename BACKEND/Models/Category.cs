namespace BACKEND.Models
{
    /// <summary>
    /// Represents a category entity with a name and description.
    /// </summary>
    public class Category : Entity
    {
        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        public string CategoryName { get; set; } = "";

        /// <summary>
        /// Gets or sets the description of the category.
        /// </summary>
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
