using BACKEND.Models.DTOs;

namespace BACKEND.Services.Interfaces
{
    public interface ICartProductService
    {
        Task<CartProductDTO> CreateAsync(CartProductDTOWrite dto);
        Task<CartProductDTO> UpdateAsync(int cartId, int productId, CartProductDTOUpdate dto);
        Task<bool> DeleteAsync(int cartId, int productId);
    }
}
