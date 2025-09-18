using AutoMapper;
using BACKEND.Data;
using BACKEND.Models;
using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderService> _logger;

        public OrderService(ShopContext context, IMapper mapper, ILogger<OrderService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<OrderDTORead>?> GetAllAsync()
        {
            _logger.LogInformation("User fetching all orders");

            var orders = await _context.Orders
                .Include(o => o.ShippingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.BillingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.ProductOrders)
                    .ThenInclude(po => po.Product)
                .AsNoTracking()
                .ToListAsync();
            if (orders.Count == 0)
            {
                _logger.LogWarning("No orders found");
                return null;
            }

            return _mapper.Map<List<OrderDTORead>>(orders);
        }

        public async Task<List<OrderDTOAdminRead>?> AdminGetAllAsync()
        {
            _logger.LogInformation("Admin fetching all orders");

            var orders = await _context.Orders
                .Include(o => o.ShippingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.BillingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.ProductOrders)
                    .ThenInclude(po => po.Product)
                .AsNoTracking()
                .ToListAsync();
            if (orders.Count == 0)
            {
                _logger.LogWarning("No orders found");
                return null;
            }
            return _mapper.Map<List<OrderDTOAdminRead>>(orders);
        }

        public async Task<OrderDTORead> GetByIdAsync(int id)
        {
            _logger.LogInformation($"Fetching order {id}");

            var order = await _context.Orders
                .Include(o => o.ShippingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.BillingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.ProductOrders)
                    .ThenInclude(po => po.Product)
                .AsNoTracking()
                .SingleOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                _logger.LogWarning("Order not found");
                return null;
            }
            return _mapper.Map<OrderDTORead>(order);
        }

        public async Task<OrderDTOAdminRead> AdminGetByIdAsync(int id)
        {
            _logger.LogInformation($"Admin fetching order {id}");

            var order = await _context.Orders
                .Include(o => o.ShippingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.BillingAddress)
                    .ThenInclude(a => a.User)
                .Include(o => o.ProductOrders)
                    .ThenInclude(po => po.Product)
                .AsNoTracking()
                .SingleOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                _logger.LogWarning("Order not found");
                return null;
            }
            return _mapper.Map<OrderDTOAdminRead>(order);
        }

        public async Task<OrderDTORead> CreateAsync(OrderDTOWrite dto)
        {
            _logger.LogInformation("Creating a new order");

            var order = _mapper.Map<Order>(dto);
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"New order created - ID: {order.Id}");

            return _mapper.Map<OrderDTORead>(order);
        }

        public async Task<OrderDTOAdminRead> AdminUpdateAsync(int id, OrderDTOAdminUpdate dto)
        {
            _logger.LogInformation($"Admin updating order - id: {id}");

            var order = await _context.Orders
                .SingleOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                _logger.LogWarning("Order not found");
                return null;
            }
            if (!Enum.IsDefined(typeof(OrderStatus), dto.OrderStatus))
            {
                throw new InvalidOperationException($"Invalid status type: {dto.OrderStatus}");
            }
            _mapper.Map(dto, order);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Order {id} updated");

            return _mapper.Map<OrderDTOAdminRead>(order);
        }

        public async Task<bool> CancelAsync(int id)
        {
            _logger.LogInformation($"Cancelling order {id}");

            var order = await _context.Orders
                .SingleOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                _logger.LogWarning("Order not found");
                return false;
            }

            order.OrderStatus = OrderStatus.Cancelled;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
