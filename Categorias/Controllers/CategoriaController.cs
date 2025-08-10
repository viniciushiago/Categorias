using Aplicacao.Interfaces;
using Dominio.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Categorias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categorias = await _service.ListarAsync();
            return Ok(categorias);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CriarCategoriaRequest request)
        {
            var categoriaId = await _service.CriarAsync(request);
            return Ok(new { id = categoriaId });
        }
    }
}
