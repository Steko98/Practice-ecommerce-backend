namespace BACKEND.Models.DTOs
{
    public record UserDTOAdminRead(
        int UserId,
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber
    );

}
