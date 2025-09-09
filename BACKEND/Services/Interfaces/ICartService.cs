using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface ICartService
    {
        Task<CartDTORead> GetByIdAsync(int id);
        Task<CartDTORead> UpdateAsync(int id, CartDTOWrite dto);
        Task<CartDTORead> ClearAsync(int id);
    }
}
