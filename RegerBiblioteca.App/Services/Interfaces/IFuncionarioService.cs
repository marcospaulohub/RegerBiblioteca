using RegerBiblioteca.App.Models.Funcionarios;

namespace RegerBiblioteca.App.Services.Interfaces
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
