using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<List<PaymentDTORead>> GetAllAsync();
        Task<List<PaymentDTOAdminRead>> AdminGetAllAsync();
        Task<PaymentDTORead?> GetByIdAsync(int id);
        Task<PaymentDTOAdminRead?> AdminGetByIdAsync(int id);
        Task<PaymentDTORead> CreateAsync(PaymentDTOWrite dto);
        Task<PaymentDTOAdminRead> UpdateAsync(int id, PaymentDTOAdminUpdate dto);
    }
}
