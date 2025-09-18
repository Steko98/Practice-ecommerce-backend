using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDTORead>>> Get()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("admin")]
        public async Task<ActionResult<List<OrderDTOAdminRead>>> AdminGet()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTORead>> GetById(int id)
        {
            var order = await _orderService.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound(new { msg = "Order not found" });
            }
            return Ok(order);
        }

        [HttpGet("admin/{id}")]
        public async Task<ActionResult<OrderDTORead>> AdminGetById(int id)
        {
            var order = await _orderService.AdminGetByIdAsync(id);
            if (order == null)
            {
                return NotFound(new { msg = "Order not found" });
            }
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDTORead>> Post(OrderDTOWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var order = await _orderService.CreateAsync(dto);
            if (order == null)
            {
                return NotFound(new { msg = "Order not found" });
            }
            return CreatedAtAction(nameof(GetById), new { id = order.OrderId }, order);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<OrderDTOAdminRead>> Patch(int id, OrderDTOAdminUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var order = await _orderService.AdminUpdateAsync(id, dto);
            if (order == null)
            {
                return NotFound(new {msg = "Order not found" });
            }
            return Ok(order);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Cancel(int id)
        {
            var order = await _orderService.CancelAsync(id);
            if (order == null)
            {
                return NotFound(new { msg = "Order not found" });
            }
            return Ok(order);
        }
    }
}
