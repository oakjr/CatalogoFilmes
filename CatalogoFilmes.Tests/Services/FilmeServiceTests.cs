using CatalogoFilmes.Application.Services;
using CatalogoFilmes.Domain.Entities;
using CatalogoFilmes.Domain.Interfaces;
using Moq;
using Xunit;

namespace CatalogoFilmes.Tests.Services
{
    public class FilmeServiceTests
    {
        private readonly Mock<IFilmeRepository> _filmeRepositoryMock;
        private readonly FilmeService _filmeService;

        public FilmeServiceTests()
        {
            _filmeRepositoryMock = new Mock<IFilmeRepository>();
            _filmeService = new FilmeService(_filmeRepositoryMock.Object);
        }

        [Fact]
        public void ObterTodos_DeveRetornarListaDeFilmes()
        {
            // Arrange
            var filmes = new List<Filme>
            {
                new Filme { Titulo = "Filme 1", Diretor = "Diretor 1", Ano = 2000, Genero = "Ação" },
                new Filme { Titulo = "Filme 2", Diretor = "Diretor 2", Ano = 2005, Genero = "Drama" }
            };

            _filmeRepositoryMock.Setup(repo => repo.ObterTodos()).Returns(filmes);

            // Act
            var resultado = _filmeService.ObterTodos();

            // Assert
            Assert.Equal(2, resultado.Count());
        }

        [Fact]
        public void ObterPorId_DeveRetornarFilme_QuandoEncontrado()
        {
            // Arrange
            var id = Guid.NewGuid();
            var filme = new Filme { Id = id, Titulo = "Filme Teste", Diretor = "Diretor", Ano = 2020, Genero = "Comédia" };

            _filmeRepositoryMock.Setup(repo => repo.ObterPorId(id)).Returns(filme);

            // Act
            var resultado = _filmeService.ObterPorId(id);

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal("Filme Teste", resultado?.Titulo);
        }

        [Fact]
        public void Adicionar_DeveChamarRepositorio()
        {
            // Arrange
            var filme = new Filme { Titulo = "Novo Filme", Diretor = "Novo Diretor", Ano = 2023, Genero = "Aventura" };

            // Act
            _filmeService.Adicionar(filme);

            // Assert
            _filmeRepositoryMock.Verify(repo => repo.Adicionar(filme), Times.Once);
        }

        [Fact]
        public void Atualizar_DeveChamarRepositorio()
        {
            // Arrange
            var filme = new Filme { Id = Guid.NewGuid(), Titulo = "Atualizado", Diretor = "Diretor", Ano = 2021, Genero = "Terror" };

            // Act
            _filmeService.Atualizar(filme);

            // Assert
            _filmeRepositoryMock.Verify(repo => repo.Atualizar(filme), Times.Once);
        }

        [Fact]
        public void Remover_DeveChamarRepositorio()
        {
            // Arrange
            var id = Guid.NewGuid();

            // Act
            _filmeService.Remover(id);

            // Assert
            _filmeRepositoryMock.Verify(repo => repo.Remover(id), Times.Once);
        }
    }
}
