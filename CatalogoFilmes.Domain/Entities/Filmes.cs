namespace CatalogoFilmes.Domain.Entities
{
    public class Filme
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Titulo { get; set; } = string.Empty;
        public string Diretor { get; set; } = string.Empty;
        public int Ano { get; set; }
        public string Genero { get; set; } = string.Empty;
    }
}
