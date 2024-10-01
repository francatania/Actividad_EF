using Microsoft.AspNetCore.Mvc;
using TurnosBack.Models;
using TurnosBack.Services;

namespace TurnosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnoController : Controller
    {
        private readonly ITurnosService _turnosService;

        public TurnoController(ITurnosService turnosService)
        {
            _turnosService = turnosService;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _turnosService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> PostTurno([FromBody] TTurno turno)
        {
            bool result;

            if (DateTime.TryParse(turno.Fecha, out DateTime fechaTurno)){

                if (fechaTurno <= DateTime.Today) {
                    return BadRequest("La fecha del turno debe ser al menos un día despues de hoy.");
                }
            }

            List<int> servicios = new List<int>();

            foreach(TDetallesTurno dt in turno.TDetallesTurnos)
            {
                if(servicios.Contains(dt.IdServicio))
                {
                    return BadRequest("No puede haber 2 servicios iguales en un mismo turno.");
                }
                servicios.Add(dt.IdServicio);
            }
        
            if(turno != null)
            {
                try
                {
                    result = await _turnosService.CrearTurno(turno);

                    if (result)
                    {
                        return Ok("Turno creado");
                    }
                    else
                    {
                        return BadRequest("No se pudo");
                    }
                }
                catch (Exception)
                {
                    return StatusCode(500, "Error");
                    throw;
                }

            }
            else
            {
                return BadRequest("Debe enviar un turno no vacío");
            }
        }
    }
}
