namespace RegerBiblioteca.Core.Entities
{
    public class LivroCategoria : BaseEntity
    {
        public LivroCategoria() { }

        public LivroCategoria(Livro livro, Categoria categoria) : base()
        {
            Livro = livro;
            Categoria = categoria;

            livro.Categorias.Add(this);
            categoria.Livros.Add(this);
        }

        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
