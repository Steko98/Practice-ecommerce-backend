using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AddressDTORead>>> Get()
        {
            var addresses = await _addressService.GetAllAsync();
            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AddressDTORead>> GetById(int id)
        {
            var address = await _addressService.GetByIdAsync(id);
            if (address == null)
            {
                return NotFound(new { msg = "Address not found" });
            }
            return Ok(address);
        }

        [HttpPost]
        public async Task<ActionResult<AddressDTORead>> Post([FromBody] AddressDTOWrite dto)
        {
            if (!ModelState.IsValid) { 
                return BadRequest(ModelState);
            }

            var address = await _addressService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = address.AddressId }, address);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AddressDTORead>> Put(int id, [FromBody] AddressDTOWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var address = await _addressService.UpdateAsync(id, dto);
            if (address == null)
            {
                return NotFound(new { msg = "Address not found" });
            }
            return Ok(address);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _addressService.DeleteAsync(id);
            if (!result)
            {
                return NotFound(new { msg = "Address not found" });
            }
            return NoContent();
        }
    }
}
