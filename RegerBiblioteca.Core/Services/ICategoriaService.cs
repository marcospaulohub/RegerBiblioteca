using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Categorias;

namespace RegerBiblioteca.Core.Services
{
    public interface ICategoriaService
    {
        ResultViewModel<int> Create(CreateCategoriaInputModel model);
        ResultViewModel Update(int id, UpdateCategoriaInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<CategoriaViewModel?> GetById(int id);
        ResultViewModel<List<CategoriaViewModel?>> GetAll();
    }
}
