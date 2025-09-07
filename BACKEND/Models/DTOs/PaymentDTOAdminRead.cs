namespace BACKEND.Models.DTOs
{
    public record PaymentDTOAdminRead(
        int PaymentId,
        int UserId,
        int OrderId,
        string PayMethod,
        decimal TotalAmount,
        PaymentStatus PaymentStatus,
        DateTime PaymentDate
        );
}
