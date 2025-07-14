using Microsoft.AspNetCore.Mvc;
using RegerBiblioteca.App.Models.Emprestimos;
using RegerBiblioteca.App.Services.Interfaces;

namespace RegerBiblioteca.API.Controllers
{

    [Route("api/emprestimo")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly IEmprestimoService _emprestimoService;

        public EmprestimoController(IEmprestimoService emprestimoService)
        {
            _emprestimoService = emprestimoService;
        }

        [HttpPost]
        public IActionResult Post(CreateEmprestimoInputModel model)
        {
            var result = _emprestimoService.Create(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        [HttpPut("{id}")]
        public IActionResult Patch(int id, UpdateEmprestimoInputModel model)
        {
            var result = _emprestimoService.Update(id, model);

            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        { 
            var result = _emprestimoService.Delete(id);
            
            if (!result.IsSuccess)
                return NotFound();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _emprestimoService.GetById(id);

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _emprestimoService.GetAll();

            if (!result.IsSuccess)
                return NotFound();

            return Ok(result);
        }
    }
}

