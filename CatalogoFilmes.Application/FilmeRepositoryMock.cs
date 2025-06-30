using CatalogoFilmes.Domain.Entities;
using CatalogoFilmes.Domain.Interfaces;

namespace CatalogoFilmes.Application.Repositories
{
    public class FilmeRepositoryMock : IFilmeRepository
    {
        private readonly List<Filme> _filmes = new()
        {
            new Filme { Titulo = "Matrix", Diretor = "Wachowski", Ano = 1999, Genero = "Ficção Científica" },
            new Filme { Titulo = "O Poderoso Chefão", Diretor = "Francis Ford Coppola", Ano = 1972, Genero = "Drama" }
        };

        public IEnumerable<Filme> ObterTodos() => _filmes;

        public Filme? ObterPorId(Guid id) => _filmes.FirstOrDefault(f => f.Id == id);

        public void Adicionar(Filme filme)
        {
            _filmes.Add(filme);
        }

        public void Atualizar(Filme filme)
        {
            var existente = ObterPorId(filme.Id);
            if (existente == null) return;

            existente.Titulo = filme.Titulo;
            existente.Diretor = filme.Diretor;
            existente.Ano = filme.Ano;
            existente.Genero = filme.Genero;
        }

        public void Remover(Guid id)
        {
            var filme = ObterPorId(id);
            if (filme != null)
                _filmes.Remove(filme);
        }
    }
}
