using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Funcionarios;

namespace RegerBiblioteca.Core.Services
{
    public interface IFuncionarioService
    {
        ResultViewModel<int> Create(CreateFuncionarioInputModel model);
        ResultViewModel Update(int id, UpdateFuncionarioInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<FuncionarioViewModel?> GetById(int id);
        ResultViewModel<List<FuncionarioViewModel?>> GetAll();
    }
}
