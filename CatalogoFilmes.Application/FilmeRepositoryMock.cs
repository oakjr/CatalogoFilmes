using CatalogoFilmes.Domain.Entities;
using CatalogoFilmes.Domain.Interfaces;

namespace CatalogoFilmes.Application.Repositories
{
    public class FilmeRepositoryMock : IFilmeRepository
    {
        private readonly List<Filme> _filmes = new()
        {
            new Filme { Titulo = "Matrix", Diretor = "Wachowski", Ano = 1999, Genero = "Ficção Científica" },
            new Filme { Titulo = "O Poderoso Chefão", Diretor = "Francis Ford Coppola", Ano = 1972, Genero = "Drama" },
            new Filme { Titulo = "Interestelar", Diretor = "Christopher Nolan", Ano = 2014, Genero = "Ficção Científica" },
            new Filme { Titulo = "Cidade de Deus", Diretor = "Fernando Meirelles", Ano = 2002, Genero = "Drama" },
            new Filme { Titulo = "Parasita", Diretor = "Bong Joon-ho", Ano = 2019, Genero = "Suspense" },
            new Filme { Titulo = "Forrest Gump", Diretor = "Robert Zemeckis", Ano = 1994, Genero = "Drama" },
            new Filme { Titulo = "Vingadores: Ultimato", Diretor = "Anthony Russo, Joe Russo", Ano = 2019, Genero = "Ação" },
            new Filme { Titulo = "A Origem", Diretor = "Christopher Nolan", Ano = 2010, Genero = "Ficção Científica" },
            new Filme { Titulo = "O Senhor dos Anéis: O Retorno do Rei", Diretor = "Peter Jackson", Ano = 2003, Genero = "Fantasia" },
            new Filme { Titulo = "Clube da Luta", Diretor = "David Fincher", Ano = 1999, Genero = "Drama" }
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
