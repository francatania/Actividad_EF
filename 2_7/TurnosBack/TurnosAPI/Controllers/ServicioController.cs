using Microsoft.AspNetCore.Mvc;
using TurnosBack.Services;

namespace TurnosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : Controller
    {
        private readonly IServicioService _servicioService;

        public ServicioController(IServicioService servicioService)
        {
            _servicioService = servicioService;


        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _servicioService.GetAll());
        }
    }
}
