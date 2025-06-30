using CatalogoFilmes.Domain.Entities;

namespace CatalogoFilmes.Domain.Interfaces
{
    public interface IFilmeRepository
    {
        IEnumerable<Filme> ObterTodos();
        Filme? ObterPorId(Guid id);
        void Adicionar(Filme filme);
        void Atualizar(Filme filme);
        void Remover(Guid id);
    }
}
