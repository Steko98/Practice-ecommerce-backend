namespace BACKEND.Models.DTOs
{
    public record ProductDTORead(
        int ProductId,
        string Name,
        string Description,
        decimal Price,
        string ImageUrl
        );
}
