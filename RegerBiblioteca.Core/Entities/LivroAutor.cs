namespace RegerBiblioteca.Core.Entities
{
    public class LivroAutor : BaseEntity
    {
        public LivroAutor() { }
        
        public LivroAutor(Livro livro, Autor autor) : base()
        {
            Livro = livro;
            Autor = autor;

            livro.Autores.Add(this);
            autor.Livros.Add(this);
        }

        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
