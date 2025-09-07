namespace BACKEND.Models.DTOs
{
    public record CategoryDTORead(
        int CategoryId,
        string CategoryName,
        string Description
        );
}
