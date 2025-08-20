using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Livros;

namespace RegerBiblioteca.Core.Services
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
