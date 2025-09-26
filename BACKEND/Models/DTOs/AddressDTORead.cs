namespace BACKEND.Models.DTOs
{
    public record AddressDTORead(
        string UserName,
        string UserLastName,
        int AddressId,
        string AddressLine1,
        string AddressLine2,
        string City,
        string PostalCode,
        string Country,
        AddressType AddressType
        );
}
