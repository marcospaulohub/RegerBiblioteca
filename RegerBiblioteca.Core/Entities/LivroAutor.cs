namespace RegerBiblioteca.Core.Entities
{
    public class LivroAutor : BaseEntity
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
