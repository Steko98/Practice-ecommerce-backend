namespace BACKEND.Models.DTOs
{
    public record OrderDTOAdminRead(
        int OrderId,
        int UserId,
        decimal TotalAmount,
        OrderStatus OrderStatus,
        DateTime OrderDate,
        AddressDTORead ShippingAddress,
        AddressDTORead BillingAddress,
        List<ProductOrderDTOAdminRead> Products
        );
}
