namespace BACKEND.Models.DTOs
{
    public record ProductOrderDTOAdminRead(
        int ProductId,
        int OrderId,
        string Name,
        decimal Price,
        int Quantity,
        string Sku
        );
}
