namespace BACKEND.Models.DTOs
{
    public record AddressDTORead(
        int AddressId,
        string AddressLine1,
        string AddressLine2,
        string City,
        string PostalCode,
        string Country,
        string AddressType
        );
}
