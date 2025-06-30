using CatalogoFilmes.Application.Services;
using CatalogoFilmes.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoFilmes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly FilmeService _filmeService;

        public FilmesController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var filmes = _filmeService.ObterTodos();
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)
        {
            var filme = _filmeService.ObterPorId(id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] Filme filme)
        {
            _filmeService.Adicionar(filme);
            return CreatedAtAction(nameof(ObterPorId), new { id = filme.Id }, filme);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, [FromBody] Filme filme)
        {
            var existente = _filmeService.ObterPorId(id);
            if (existente == null) return NotFound();

            filme.Id = id;
            _filmeService.Atualizar(filme);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(Guid id)
        {
            var existente = _filmeService.ObterPorId(id);
            if (existente == null) return NotFound();

            _filmeService.Remover(id);
            return NoContent();
        }
    }
}
