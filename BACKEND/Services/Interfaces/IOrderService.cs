using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDTORead>> GetAllAsync();
        Task<List<OrderDTOAdminRead>> AdminGetAllAsync();
        Task<OrderDTORead?> GetByIdAsync(int id);
        Task<OrderDTOAdminRead?> AdminGetByIdAsync(int id);
        Task<OrderDTORead> CreateAsync(OrderDTOWrite dto);
        Task<OrderDTOAdminRead> AdminUpdateAsync(int id, OrderDTOAdminUpdate dto);
        Task<bool> CancelAsync(int id);
    }
}
