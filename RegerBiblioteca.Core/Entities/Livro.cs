namespace RegerBiblioteca.Core.Entities
{
    public class Livro : BaseEntity
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public List<LivroAutor> Autores { get; set; } = [];
        public List<LivroCategoria> Categorias { get; set; } = [];
    }
}
