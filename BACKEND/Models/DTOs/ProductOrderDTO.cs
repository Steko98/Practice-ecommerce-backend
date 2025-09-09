namespace BACKEND.Models.DTOs
{
    public record ProductOrderDTO(
        int ProductId,
        string Name,
        decimal Price,
        int Quantity,
        string ImageUrl
        );
}
