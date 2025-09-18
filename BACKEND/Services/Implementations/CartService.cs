using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<CartService> _logger;

        public CartService(ShopContext context, IMapper mapper, ILogger<CartService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CartDTORead> GetByIdAsync(int id)
        {
            _logger.LogInformation($"Fetching cart ID - {id}");

            var cart = await _context.Carts
                .AsNoTracking()
                .Include(c => c.CartProducts)
                    .ThenInclude(cp => cp.Product)
                .SingleOrDefaultAsync(c => c.Id == id);
            if (cart == null)
            {
                _logger.LogWarning("Cart not found");
                return null;
            }

            return _mapper.Map<CartDTORead>(cart);
        }

        //public async Task<CartDTORead?> UpdateAsync(int id, CartDTOWrite dto)
        //{
        //    _logger.LogInformation($"Updating cart - ID: {id}");

        //    var cart = await _context.Carts
        //        .Include(c => c.CartProducts)
        //            .ThenInclude(cp => cp.Product)
        //        .SingleOrDefaultAsync(c => c.Id == id);
        //    if (cart == null)
        //    {
        //        _logger.LogWarning("Cart not found");
        //        return null;
        //    }

        //    foreach (var productId in dto.ProductIds)
        //    {
        //        cart.CartProducts.Add(new CartProduct
        //        {
        //            ProductId = productId,

        //            Quantity = 1
        //        });
        //    }

        //    await _context.SaveChangesAsync();

        //    _logger.LogInformation($"Cart updated - ID: {id}");

        //    return _mapper.Map<CartDTORead>(cart);
        //}

        public async Task<CartDTORead> ClearAsync(int id)
        {
            _logger.LogInformation($"Clearing cart - ID: {id}");

            var cart = await _context.Carts
                .Include(c => c.CartProducts)
                    .ThenInclude(cp => cp.Product)
                .SingleOrDefaultAsync(c => c.Id == id);
            if (cart == null)
            {
                _logger.LogWarning("Cart not found");
                return null;
            }

            if (cart.CartProducts.Count == 0)
            {
                _logger.LogWarning($"Cart is already empty");
                return _mapper.Map<CartDTORead>(cart);
            }

            cart.CartProducts.Clear();
            await _context.SaveChangesAsync();

            _logger.LogInformation("Cart emptied");

            return _mapper.Map<CartDTORead>(cart);
        }
    }
}
