namespace BACKEND.Models.DTOs
{
    public record CartProductDTO
    (
        int ProductId,
        string Name,
        decimal Price,
        int Quantity,
        string ImageUrl
        );
}
