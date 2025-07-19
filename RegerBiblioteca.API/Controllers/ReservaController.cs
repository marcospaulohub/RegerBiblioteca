using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.App.Models.Reservas;
using RegerBiblioteca.App.Services.Interfaces;

namespace RegerBiblioteca.API.Controllers
{
    [Route("api/reserva")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService _reservaService;
        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpPost]
        public IActionResult Post(CreateReservaInputModel model)
        {
            var result = _reservaService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateReservaInputModel model)
        {
            var result = _reservaService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _reservaService.Delete(id);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _reservaService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _reservaService.GetAll();

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }
    }
}
