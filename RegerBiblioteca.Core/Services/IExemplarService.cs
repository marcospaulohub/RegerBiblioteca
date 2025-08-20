using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Exemplares;

namespace RegerBiblioteca.Core.Services
{
    public interface IExemplarService
    {
        ResultViewModel<int> Create(CreateExemplarInputModel model);
        ResultViewModel Update(int id, UpdateExemplarInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<ExemplarViewModel?> GetById(int id);
        ResultViewModel<List<ExemplarViewModel?>> GetAll();
    }
}
