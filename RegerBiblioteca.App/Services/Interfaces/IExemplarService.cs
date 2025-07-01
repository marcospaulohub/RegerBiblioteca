using RegerBiblioteca.App.Models.Exemplares;

namespace RegerBiblioteca.App.Services.Interfaces
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
