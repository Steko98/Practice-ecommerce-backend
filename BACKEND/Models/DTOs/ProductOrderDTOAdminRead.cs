namespace BACKEND.Models.DTOs
{
    public record ProductOrderDTOAdminRead(
        int ProductId,
        string Name,
        decimal Price,
        int Quantity,
        string Sku
        );
}
