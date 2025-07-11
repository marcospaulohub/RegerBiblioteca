using RegerBiblioteca.App.Models.Livros;
using RegerBiblioteca.App.Models.Reservas;

namespace RegerBiblioteca.App.Services.Interfaces
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
