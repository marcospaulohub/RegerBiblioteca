using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Usuarios;

namespace RegerBiblioteca.Core.Services
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
