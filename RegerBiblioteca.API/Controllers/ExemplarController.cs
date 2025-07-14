using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.App.Models.Exemplares;
using RegerBiblioteca.App.Services.Interfaces;

namespace RegerBiblioteca.API.Controllers
{

    [Route("api/exemplar")]
    [ApiController]
    public class ExemplarController : ControllerBase
    {
        private readonly IExemplarService _exemplarService;

        public ExemplarController(IExemplarService exemplarService)
        {
            _exemplarService = exemplarService;
        }

        [HttpPost]
        public IActionResult Post(CreateExemplarInputModel model)
        {
            var result = _exemplarService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateExemplarInputModel model)
        {
            var result = _exemplarService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _exemplarService.Delete(id);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _exemplarService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _exemplarService.GetAll();
            return Ok(result);
        }

    }
}
