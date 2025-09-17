using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(ShopContext context, IMapper mapper, ILogger<ProductService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<ProductDTORead>> GetAllAsync()
        {
            _logger.LogInformation("User fetching all products");

            var products = await _context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .ToListAsync();

            return _mapper.Map<List<ProductDTORead>>(products);
        }

        public async Task<List<ProductDTOAdminRead>> AdminGetAllAsync()
        {
            _logger.LogInformation("Admin fetching all products");

            var products = await _context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .ToListAsync();

            return _mapper.Map<List<ProductDTOAdminRead>>(products);
        }

        public async Task<ProductDTORead> GetByIdAsync(int id)
        {
            _logger.LogInformation($"User fetching product - ID: {id}");

            var product = await _context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .SingleOrDefaultAsync(p =>  p.Id == id);
            if (product == null)
            {
                _logger.LogWarning($"Product ID: {id} not found");
                return null;
            }
            return _mapper.Map<ProductDTORead>(product);
        }

        public async Task<ProductDTOAdminRead> AdminGetByIdAsync(int id)
        {
            _logger.LogInformation($"Admin fetching product - ID: {id}");

            var product = await _context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .SingleOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                _logger.LogWarning($"Product ID: {id} not found");
                return null;
            }

            return _mapper.Map<ProductDTOAdminRead>(product);
        }

        public async Task<ProductDTOAdminRead> CreateAsync(ProductDTOAdminWrite dto)
        {
            _logger.LogInformation("Creating a new product");

            var product = _mapper.Map<Product>(dto);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Created product {product.Name}");

            return _mapper.Map<ProductDTOAdminRead>(product);
        }

        public async Task<ProductDTOAdminRead> UpdateAsync(int id,  ProductDTOAdminWrite dto)
        {
            _logger.LogInformation($"Updating product {id}");

            var product = await _context.Products
                .SingleOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                _logger.LogWarning($"Product ID: {id} not found");
                return null;
            }
            _mapper.Map(dto, product);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductDTOAdminRead>(product) ;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _logger.LogInformation($"Deleting product {id}");

            var product = await _context.Products
                .SingleOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                _logger.LogWarning($"Product ID: {id} not found");
                return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted product - ID {id}");

            return true;
        }
    }
}
