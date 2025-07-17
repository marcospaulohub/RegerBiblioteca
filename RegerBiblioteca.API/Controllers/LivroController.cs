using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.App.Models.Livros;
using RegerBiblioteca.App.Services.Interfaces;

namespace RegerBiblioteca.API.Controllers
{
    [Route("api/livro")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;
        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpPost]
        public IActionResult Post(CreateLivroInputModel model)
        {
            var result = _livroService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateLivroInputModel model)
        {
            var result = _livroService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _livroService.Delete(id);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _livroService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _livroService.GetAll();

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }
    }
}
