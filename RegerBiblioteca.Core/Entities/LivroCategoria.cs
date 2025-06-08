namespace RegerBiblioteca.Core.Entities
{
    public class LivroCategoria : BaseEntity
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
