using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface IAddressService
    {
        Task<List<AddressDTORead>> GetAllAsync();
        Task<AddressDTORead> GetByIdAsync(int id);
        Task<AddressDTORead> CreateAsync(AddressDTOWrite dto);
        Task<AddressDTORead> UpdateAsync(int id, AddressDTOWrite dto);
        Task<bool> DeleteAsync(int id);
    }
}
