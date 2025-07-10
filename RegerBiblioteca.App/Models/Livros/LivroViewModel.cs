using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.App.Models.Livros
{
    public class LivroViewModel
    {
        public LivroViewModel(string titulo, string iSBN, int anoPublicacao)
        {
            Titulo = titulo;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
        }

        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public static LivroViewModel FromEntity(Livro livro)
        {
            return new LivroViewModel(
                livro.Titulo,
                livro.ISBN,
                livro.AnoPublicacao);
        }
    }
}
