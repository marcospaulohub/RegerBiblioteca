using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Emprestimos;

namespace RegerBiblioteca.Core.Services
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
