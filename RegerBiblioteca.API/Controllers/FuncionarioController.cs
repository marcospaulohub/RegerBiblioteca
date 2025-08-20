using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels.Funcionarios;

namespace RegerBiblioteca.API.Controllers
{
    [Route("api/funcionario")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _funcionarioService;
        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost]
        public IActionResult Post(CreateFuncionarioInputModel model)
        {
            var result = _funcionarioService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateFuncionarioInputModel model)
        {
            var result = _funcionarioService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _funcionarioService.Delete(id);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _funcionarioService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _funcionarioService.GetAll();

            return Ok(result);
        }
    }
}
