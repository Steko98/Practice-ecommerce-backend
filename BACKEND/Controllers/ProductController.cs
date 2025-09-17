using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) { 
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTORead>>> Get()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("admin")]
        public async Task<ActionResult<List<ProductDTOAdminRead>>> AdminGet()
        {
            var products = await _productService.AdminGetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTORead>> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            return Ok(product);
        }

        [HttpGet("admin/{id}")]
        public async Task<ActionResult<ProductDTOAdminRead>> AdminGetById(int id)
        {
            var product = await _productService.AdminGetByIdAsync(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTOAdminRead>> Post(ProductDTOAdminWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var product = await _productService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = product.ProductId},product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDTOAdminRead>> Put(int id, ProductDTOAdminWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var product = await _productService.UpdateAsync(id, dto);
            if (product == null)
            {
                return NotFound(new { msg = "Product not found" });
            }

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _productService.DeleteAsync(id);
            if (!result)
            {
                return NotFound(new { msg = "Product not found" });
            }
            return NoContent();
        }

    }
}
