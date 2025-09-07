namespace BACKEND.Models.DTOs
{
    public record OrderItemDTOAdminRead(
        int ProductId,
        string Name,
        decimal Price,
        int Quantity,
        string Sku
        );
}
