using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models
{
    /// <summary>
    /// Represents the base class for all entities in the system.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}
