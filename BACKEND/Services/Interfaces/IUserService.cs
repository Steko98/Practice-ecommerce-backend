using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTOAdminRead>> AdminGetAllAsync();
        Task<UserDTORead?> GetByIdAsync(int id);
        Task<UserDTOAdminRead?> AdminGetByIdAsync(int id);
        Task<UserDTORead> CreateAsync(UserDTOWrite dto);
        Task<UserDTORead> UpdateAsync(int id, UserDTOWrite dto);
        Task<bool> DeleteAsync(int id);
    }
}
