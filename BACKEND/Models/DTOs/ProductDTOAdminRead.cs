namespace BACKEND.Models.DTOs
{
    public record ProductDTOAdminRead(
        int ProductId,
        string Name,
        string Description,
        decimal Price,
        string Sku,
        int StockQuantity,
        string ImageUrl,
        List<int> CategoryIds,
        List<string> CategoryNames
        );
}
