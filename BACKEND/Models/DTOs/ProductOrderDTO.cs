namespace BACKEND.Models.DTOs
{
    public record ProductOrderDTO(
        int ProductId,
        int OrderId,
        string Name,
        decimal Price,
        int Quantity,
        string ImageUrl
        );
}
