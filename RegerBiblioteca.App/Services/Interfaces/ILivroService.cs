using RegerBiblioteca.App.Models.Livros;

namespace RegerBiblioteca.App.Services.Interfaces
{
    public interface ILivroService
    {
        ResultViewModel<int> Create(CreateLivroInputModel model);
        ResultViewModel Update(int id, UpdateLivroInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<LivroViewModel?> GetById(int id);
        ResultViewModel<List<LivroViewModel?>> GetAll();
    }
}
