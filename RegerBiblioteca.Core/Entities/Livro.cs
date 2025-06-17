namespace RegerBiblioteca.Core.Entities
{
    public class Livro : BaseEntity
    {
        public Livro() { }

        public Livro(string titulo, string iSBN, int anoPublicacao) : base()
        {
            Titulo = titulo;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
        }

        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public List<LivroAutor> Autores { get; set; } = [];
        public List<LivroCategoria> Categorias { get; set; } = [];
        public List<Exemplar> Exemplares { get; set; } = [];
    }
}
