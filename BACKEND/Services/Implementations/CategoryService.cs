using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(ShopContext context, IMapper mapper, ILogger<CategoryService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<CategoryDTORead>> GetAllAsync()
        {
            _logger.LogInformation("Fetching all categories");

            var categories = await _context.Categories
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<List<CategoryDTORead>>(categories);
        }

        public async Task<CategoryDTORead> GetByIdAsync(int id)
        {
            _logger.LogInformation($"Fetching category ID: {id}");

            var category = await _context.Categories
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                _logger.LogWarning($"Category ID{id} not found");
                return null;
            }

            return _mapper.Map<CategoryDTORead>(category);
        }

        public async Task<CategoryDTORead> CreateAsync(CategoryDTOWrite dto)
        {
            _logger.LogInformation($"Creating a new category: {dto.CategoryName}");

            var category = _mapper.Map<Category>(dto);
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Created category ID: {category.Id}");

            return _mapper.Map<CategoryDTORead>(category);
        }

        public async Task<CategoryDTORead> UpdateAsync(int id, CategoryDTOWrite dto)
        {
            _logger.LogInformation($"Updating category - ID: {id}");

            var category = await _context.Categories
                .SingleOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                _logger.LogWarning($"Category with ID: {id} not found");
                return null;
            }

            _mapper.Map(dto, category);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Category updated - ID{id}");

            return _mapper.Map<CategoryDTORead>(category);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await _context.Categories
                .SingleOrDefaultAsync(c => c.Id == id);
            if (category == null) {
                _logger.LogWarning($"Category ID: {id} not found");
                return false;
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted category - ID {id}");

            return true;
        }
    }
}
