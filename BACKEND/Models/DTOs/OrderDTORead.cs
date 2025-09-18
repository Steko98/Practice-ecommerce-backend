namespace BACKEND.Models.DTOs
{
    public record OrderDTORead(
        int OrderId,
        decimal TotalAmount,
        OrderStatus OrderStatus,
        DateTime OrderDate,
        AddressDTORead ShippingAddress,
        AddressDTORead BillingAddress,
        List<ProductOrderDTO> Products
        );
}
