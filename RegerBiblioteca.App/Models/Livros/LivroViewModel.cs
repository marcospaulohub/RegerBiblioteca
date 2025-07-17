using RegerBiblioteca.App.Models.Autores;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.App.Models.Livros
{
    public class LivroViewModel
    {
        public LivroViewModel(int id, string titulo, string iSBN, int anoPublicacao, List<AutorResumoViewModel> autores)
        {
            Id = id;
            Titulo = titulo;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
            Autores = autores;
        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
        public List<AutorResumoViewModel> Autores { get; set; } = [];

        public static LivroViewModel FromEntity(Livro livro)
        {
            return new LivroViewModel(
                livro.Id,
                livro.Titulo,
                livro.ISBN,
                livro.AnoPublicacao,
                livro.Autores.Select(la => AutorResumoViewModel.FromEntity(la.Autor)).ToList());
        }
    }
}
