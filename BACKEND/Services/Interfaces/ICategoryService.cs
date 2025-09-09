using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDTORead>> GetAllAsync();
        Task<CategoryDTORead?> GetByIdAsync(int id);
        Task<CategoryDTORead> CreateAsync(CategoryDTOWrite dto);
        Task<CategoryDTORead> UpdateAsync(int id, CategoryDTOWrite dto);
        Task<bool> DeleteAsync(int id);
    }
}
