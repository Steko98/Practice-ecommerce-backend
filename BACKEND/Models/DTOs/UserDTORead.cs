namespace BACKEND.Models.DTOs
{
    public record UserDTORead(
        int UserId,
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber
        );
}
