using System.ComponentModel.DataAnnotations;

namespace BACKEND.Models.DTOs
{
    public class CartDTOWrite
    {
        public List<int> ProductIds { get; set; } = new();
    }
}
