using RegerBiblioteca.App.Models.Emprestimos;

namespace RegerBiblioteca.App.Services.Interfaces
{
    public interface IEmprestimoService
    {
        ResultViewModel<int> Create(CreateEmprestimoInputModel model);
        ResultViewModel Update(int id, UpdateEmprestimoInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<EmprestimoViewModel?> GetById(int id);
        ResultViewModel<List<EmprestimoViewModel?>> GetAll();
    }
}
