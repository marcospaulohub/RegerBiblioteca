using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels.Categorias;

namespace RegerBiblioteca.API.Controllers
{
    [Route("api/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpPost]
        public IActionResult Post(CreateCategoriaInputModel model)
        {
            var result = _categoriaService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateCategoriaInputModel model)
        {
            var result = _categoriaService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _categoriaService.Delete(id);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _categoriaService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _categoriaService.GetAll();

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }
    }
}
