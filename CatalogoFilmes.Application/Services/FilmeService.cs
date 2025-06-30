using CatalogoFilmes.Domain.Entities;
using CatalogoFilmes.Domain.Interfaces;

namespace CatalogoFilmes.Application.Services
{
    public class FilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public IEnumerable<Filme> ObterTodos()
        {
            return _filmeRepository.ObterTodos();
        }

        public Filme? ObterPorId(Guid id)
        {
            return _filmeRepository.ObterPorId(id);
        }

        public void Adicionar(Filme filme)
        {
            _filmeRepository.Adicionar(filme);
        }

        public void Atualizar(Filme filme)
        {
            _filmeRepository.Atualizar(filme);
        }

        public void Remover(Guid id)
        {
            _filmeRepository.Remover(id);
        }
    }
}
