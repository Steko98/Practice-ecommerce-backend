namespace BACKEND.Models.DTOs
{
    public record CartDTORead(
        int CartId,
        List<CartProductDTO> Products,
        decimal TotalAmount
        );
}
