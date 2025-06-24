using RegerBiblioteca.App.Models.Autores;

namespace RegerBiblioteca.App.Services.Interfaces
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
