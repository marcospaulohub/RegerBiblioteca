using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Core.ViewModels.Autores
{
    public class AutorResumoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static AutorResumoViewModel FromEntity(Autor autor)
        => new() { Id = autor.Id, Nome = autor.Nome };
    }
}
