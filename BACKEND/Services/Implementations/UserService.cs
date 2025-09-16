using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;

        public UserService(ShopContext context, IMapper mapper, ILogger<UserService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<UserDTOAdminRead>> AdminGetAllAsync()
        {
            _logger.LogInformation("Admin fetching all users");

            var users = await _context.Users
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<List<UserDTOAdminRead>>(users);
        }
        public async Task<UserDTORead?> GetByIdAsync(int id)
        {
            _logger.LogInformation($"Fetching user with ID {id}");

            var user = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u=> u.Id == id && !u.IsDeleted);

            if (user == null)
            {
                _logger.LogWarning($"User ID {id} not found");
                return null;
            }
            return _mapper.Map<UserDTORead>(user);
        }

        public async Task<UserDTOAdminRead?> AdminGetByIdAsync(int id)
        {
            _logger.LogInformation($"Admin fetching user with ID {id}");

            var user = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                _logger.LogWarning($"User ID {id} not found");
                return null;
            }
            return _mapper.Map<UserDTOAdminRead>(user);
        }

        public async Task<UserDTORead> CreateAsync(UserDTOWrite dto)
        {
            _logger.LogInformation($"Creating user with Email {dto.Email}");

            if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
            {
                throw new InvalidOperationException("Email is already in use.");
            }

            var user = _mapper.Map<User>(dto);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Created User with Email {dto.Email}");

            return _mapper.Map<UserDTORead>(user);
        }

        public async Task<UserDTORead?> UpdateAsync (int id, UserDTOWrite dto)
        {
            _logger.LogInformation($"Updating User ID {id}");

            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null)
            {
                _logger.LogWarning($"User ID {id} not found");
                return null;
            }
            if (await _context.Users.AnyAsync(u => u.Email == dto.Email && u.Id != id && !u.IsDeleted))
            {
                throw new InvalidOperationException("Email is already in use.");
            }
            _mapper.Map(dto, user);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Updated User Id {id}");

           return _mapper.Map<UserDTORead>(user);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _logger.LogInformation($"Deleting User ID {id}");

            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null)
            {
                _logger.LogWarning($"User ID {id} not found");
                return false;
            }

            user.IsDeleted = true;

            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted User Id {id}");

            return true;
        }

    }
}
