using RegerBiblioteca.App.Models.Reservas;
using RegerBiblioteca.App.Models.Usuarios;

namespace RegerBiblioteca.App.Services.Interfaces
{
    public interface IUsuarioService
    {
        ResultViewModel<int> Create(CreateUsuarioInputModel model);
        ResultViewModel Update(int id, UpdateUsuarioInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<UsuarioViewModel?> GetById(int id);
        ResultViewModel<List<UsuarioViewModel?>> GetAll();
    }
}
