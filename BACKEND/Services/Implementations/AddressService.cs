using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<AddressService> _logger;

        public AddressService(ShopContext context, IMapper mapper, ILogger<AddressService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<AddressDTORead>> GetAllAsync()
        {
            _logger.LogInformation($"Fetching all addresses");

            var addresses = await _context.Addresses
                .AsNoTracking()
                .ToListAsync();
        
            return _mapper.Map<List<AddressDTORead>>( addresses );
        }

        public async Task<AddressDTORead?> GetByIdAsync(int id)
        {
            _logger.LogInformation($"Fetching address with Id {id}");

            var address = await _context.Addresses
                .AsNoTracking()
                .SingleOrDefaultAsync(a => a.Id == id);
            if (address == null)
            {
                _logger.LogWarning($"Address under ID {id} not found");
                return null;
            }
            return _mapper.Map<AddressDTORead> ( address );
        }

        public async Task<AddressDTORead> CreateAsync(AddressDTOWrite dto)
        {
            _logger.LogInformation($"Creating address...");

            if (!Enum.IsDefined(typeof(AddressType), dto.AddressType))
            {
                throw new InvalidOperationException($"Invalid address type: {dto.AddressType}");
            }
            if (await _context.Addresses.AnyAsync(a => a.AddressLine1 == dto.AddressLine1))
            {
                throw new InvalidOperationException("Address is already in use");
            }
            var address = _mapper.Map<Address>(dto);

            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Created a new address: {dto.AddressLine1}");

            return _mapper.Map<AddressDTORead>(address);
        }

        public async Task<AddressDTORead> UpdateAsync(int id, AddressDTOWrite dto)
        {
            _logger.LogInformation($"Updating address. ID: {id}");

            var address = await _context.Addresses
                .SingleOrDefaultAsync(a => a.Id == id);
            if (address == null) {
                _logger.LogWarning($"Address ID {id} not found");
                return null;
            }
            if (!Enum.IsDefined(typeof(AddressType), dto.AddressType))
            {
                throw new InvalidOperationException($"Invalid address type: {dto.AddressType}");
            }
            if (await _context.Addresses.AnyAsync(a => a.AddressLine1 == dto.AddressLine1 && a.Id != id))
            {
                throw new InvalidOperationException("Address is already in use");
            }
            _mapper.Map(dto, address);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Updated address: ID {id}");

            return _mapper.Map<AddressDTORead>(address);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _logger.LogInformation($"Deleting address ID: {id}");

            var address = await _context.Addresses
                .SingleOrDefaultAsync(a => a.Id == id);
            if (address == null)
            {
                _logger.LogWarning($"Address ID {id} not found");
                return false;
            }

            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted address ID: {id}");

            return true;
        }
    }
}
