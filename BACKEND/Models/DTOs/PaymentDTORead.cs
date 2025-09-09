namespace BACKEND.Models.DTOs
{
    public record PaymentDTORead(
        int PaymentId,
        int OrderId,
        string PayMethod,
        decimal TotalAmount,
        PaymentStatus PaymentStatus,
        DateTime PaymentDate
        );
}
