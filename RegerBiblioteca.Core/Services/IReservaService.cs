using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Reservas;

namespace RegerBiblioteca.Core.Services
{
    public interface IReservaService
    {
        ResultViewModel<int> Create(CreateReservaInputModel model);
        ResultViewModel Update(int id, UpdateReservaInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<ReservaViewModel?> GetById(int id);
        ResultViewModel<List<ReservaViewModel?>> GetAll();
    }
}
