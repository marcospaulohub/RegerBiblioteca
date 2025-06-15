namespace RegerBiblioteca.Core.Entities
{
    public class Autor : BaseEntity
    {
        public string Nome { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataFalecimento { get; set; }
        public string? Biografia { get; set; }
        public string? FotoUrl { get; set; }
        public string? SiteUrl { get; set; }

        public List<LivroAutor> Livros { get; set; } = [];
    }
}
