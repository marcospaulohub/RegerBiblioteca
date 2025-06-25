using RegerBiblioteca.App.Models.Categorias;

namespace RegerBiblioteca.App.Services.Interfaces
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
