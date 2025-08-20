using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Autores;

namespace RegerBiblioteca.Core.Services
{
    public interface IAutorService
    {
        ResultViewModel<int> Create(CreateAutorInputModel model);
        ResultViewModel Update(int id, UpdateAutorInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<AutorViewModel?> GetById(int id);
        ResultViewModel<List<AutorViewModel?>> GetAll();
    }
}
