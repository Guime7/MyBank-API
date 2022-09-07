using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoCreditoController : ControllerBase
    {

        private ICartaoCreditoServices _cartaocreditoServices;

        public CartaoCreditoController(ICartaoCreditoServices cartaoCreditoServices)
        {
            _cartaocreditoServices = cartaoCreditoServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
