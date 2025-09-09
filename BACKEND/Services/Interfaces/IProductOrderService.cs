using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface IProductOrderService
    {
        Task<List<ProductOrderDTO>> GetAllByOrderAsync(int orderId);
        Task<List<ProductOrderDTOAdminRead>> AdminGetAllAsync(int orderId);
        Task<ProductOrderDTO> AddToOrderAsync(ProductOrderDTOWrite dto);
        Task<ProductOrderDTO> UpdateAsync(ProductOrderDTOWrite dto, int id);
        Task<bool> RemoveFromOrderAsync(int id);
    }
}
