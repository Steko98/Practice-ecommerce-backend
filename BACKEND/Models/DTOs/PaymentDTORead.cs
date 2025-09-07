namespace BACKEND.Models.DTOs
{
    public record PaymentDTORead(
        int PaymentId,
        int OrderId,
        decimal TotalAmount,
        PaymentStatus PaymentStatus,
        DateTime PaymentDate
        );
}
