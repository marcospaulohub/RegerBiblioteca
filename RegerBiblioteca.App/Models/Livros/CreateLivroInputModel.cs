namespace RegerBiblioteca.App.Models.Livros
{
    public class CreateLivroInputModel
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
