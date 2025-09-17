namespace BACKEND.Models.DTOs
{
    public record ProductDTORead(
        int ProductId,
        string Name,
        string Description,
        decimal Price,
        int CategoryId,
        string ImageUrl
        );
}
