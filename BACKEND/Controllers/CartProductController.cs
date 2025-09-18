using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartProductController : ControllerBase
    {
        private readonly ICartProductService _cartProductService;

        public CartProductController(ICartProductService cartProductService)
        {
            _cartProductService = cartProductService;
        }

        [HttpPost]
        public async Task<ActionResult<CartProductDTO>> Post(CartProductDTOWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var cartProduct = await _cartProductService.CreateAsync(dto);

            return Ok(cartProduct);
        }

        [HttpPut("{cartId}/{productId}")]
        public async Task<ActionResult<CartProductDTO>> UpdateAsync(int cartId, int productId, CartProductDTOUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }
            var cartProduct = await _cartProductService.UpdateAsync(cartId, productId, dto);
            if (cartProduct == null)
            {
                return NotFound("Cart or product not found");
            }
            return Ok(cartProduct);
        }

        [HttpDelete("{cartId}/{productId}")]
        public async Task<ActionResult> Delete(int cartId, int productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _cartProductService.DeleteAsync(cartId, productId);
            if (!result)
            {
                return NotFound(new { msg = "Cart or product not found" });
            }
            return NoContent();
        }

    }
}
