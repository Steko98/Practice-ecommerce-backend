using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDTORead>> GetAllAsync();
        Task<List<ProductDTOAdminRead>> AdminGetAllAsync();
        Task<ProductDTORead?> GetByIdAsync(int id);
        Task<ProductDTOAdminRead?> AdminGetByIdAsync(int id);
        Task<ProductDTOAdminRead> CreateAsync(ProductDTOAdminWrite dto);
        Task<ProductDTOAdminRead> UpdateAsync(int id, ProductDTOAdminWrite dto);
        Task<OrderDTORead?> DeleteAsync(int id);
    }
}
