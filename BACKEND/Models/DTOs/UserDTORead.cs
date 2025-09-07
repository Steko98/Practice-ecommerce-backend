namespace BACKEND.Models.DTOs
{
    public record UserDTORead(
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber
        );
}
