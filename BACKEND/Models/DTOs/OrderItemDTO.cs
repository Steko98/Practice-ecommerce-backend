namespace BACKEND.Models.DTOs
{
    public record OrderItemDTO(
        int ProductId,
        string Name,
        decimal Price,
        int Quantity,
        string ImageUrl
        );
}
