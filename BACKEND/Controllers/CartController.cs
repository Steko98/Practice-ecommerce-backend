using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CartDTORead>> GetById(int id)
        {
            var cart = await _cartService.GetByIdAsync(id);
            if (cart == null)
            {
                return NotFound(new { msg = "Cart not found" });
            }

            return Ok(cart);
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<CartDTORead>> Put(int id, CartDTOWrite dto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var cart = await _cartService.UpdateAsync(id, dto);
        //    if (cart == null)
        //    {
        //        return NotFound(new { msg = "Cart not found" });
        //    }

        //    return Ok(cart);
        //}

        [HttpDelete("{id}")]
        public async Task<ActionResult<CartDTORead>> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cart = await _cartService.ClearAsync(id);
            if (cart == null)
            {
                return NotFound(new { msg = "Cart not found" });
            }

            return Ok(cart);
        }
    }
}
