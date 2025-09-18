using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class CartProductService : ICartProductService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<CartProductService> _logger;

        public CartProductService(ShopContext context, IMapper mapper, ILogger<CartProductService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CartProductDTO> CreateAsync(CartProductDTOWrite dto)
        {
            _logger.LogInformation($"Creating new CartProduct - CartID:{dto.CartId} ProductID:{dto.ProductId}");

            var cartProduct = _mapper.Map<CartProduct>(dto);

            _context.CartProducts.Add(cartProduct);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"New CartProduct created - CartID:{dto.CartId} ProductID:{dto.ProductId}");

            return _mapper.Map<CartProductDTO>(cartProduct);
        }

        public async Task<CartProductDTO> UpdateAsync(int cartId, int productId, CartProductDTOUpdate dto)
        {
            _logger.LogInformation($"Updating CartProduct - CartID:{cartId} ProductID: {productId}");

            var cartProduct = await _context.CartProducts
                .FirstOrDefaultAsync(cp => cp.CartId == cartId && cp.ProductId == productId);

            if (cartProduct == null)
            {
                _logger.LogWarning("CartProduct not found");
                return null;    
            }

            cartProduct.Quantity = dto.Quantity;

            await _context.SaveChangesAsync();

            _logger.LogInformation($"CartProduct updated: CartID: {cartId}");

            return _mapper.Map<CartProductDTO>(cartProduct);
        }

        public async Task<bool> DeleteAsync(int cartId, int productId)
        {
            _logger.LogInformation($"Deleting product {productId} from cart {cartId}");

            var cartProduct = await _context.CartProducts
                .FirstOrDefaultAsync(cp => cp.ProductId == productId && cp.CartId == cartId);

            if (cartProduct == null)
            {
                _logger.LogWarning("Cart or Product not found");
                return false;
            }

            _context.CartProducts.Remove(cartProduct);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Product removed from the cart");

            return true;
        }
    }
}
