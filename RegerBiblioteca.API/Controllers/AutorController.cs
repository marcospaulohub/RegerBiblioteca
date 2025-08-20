using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels.Autores;

namespace RegerBiblioteca.API.Controllers
{
    [Route("api/autor")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        [HttpPost]
        public IActionResult Post(CreateAutorInputModel model)
        {
            var result = _autorService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateAutorInputModel model)
        {
            var result = _autorService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _autorService.Delete(id);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _autorService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _autorService.GetAll();

            if(!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }
    }
}
