using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Emprestimos;

namespace RegerBiblioteca.App.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        private readonly IEmprestimoRepository _emprestimoRepository;

        public EmprestimoService(IEmprestimoRepository emprestimoRepository)
        {
            _emprestimoRepository = emprestimoRepository;
        }

        public ResultViewModel<int> Create(CreateEmprestimoInputModel model)
        {
            var emprestimo = new Emprestimo
            {
                FuncionarioId = model.FuncionarioId,
                UsuarioId = model.UsuarioId,
                ExemplarId = model.ExemplarId
            };

            var emprestimoId = _emprestimoRepository.Insert(emprestimo);

            if (emprestimoId <= 0)
                return ResultViewModel<int>.Error("Erro ao criar empréstimo.");
            
            return ResultViewModel<int>.Success(emprestimoId);
        }

        public ResultViewModel Update(int id, UpdateEmprestimoInputModel model)
        {
            var emprestimo = _emprestimoRepository.GetById(id);

            if (emprestimo == null)
                return ResultViewModel.Error("Empréstimo não encontrado.");
            
            emprestimo.FuncionarioId = model.FuncionarioId;
            emprestimo.UsuarioId = model.UsuarioId;
            emprestimo.ExemplarId = model.ExemplarId;
            
            _emprestimoRepository.Update(emprestimo);
            
            return ResultViewModel.Success();
        }

        public ResultViewModel Delete(int id)
        {
            var emprestimo = _emprestimoRepository.GetById(id);
            
            if (emprestimo == null)
                return ResultViewModel.Error("Empréstimo não encontrado.");
            
            _emprestimoRepository.Delete(emprestimo);
            
            return ResultViewModel.Success();
        }

        public ResultViewModel<EmprestimoViewModel?> GetById(int id)
        {
            var emprestimo = _emprestimoRepository.GetById(id);

            return emprestimo is null ?
                ResultViewModel<EmprestimoViewModel?>.Error("Empréstimo não encontrado.") : 
                ResultViewModel<EmprestimoViewModel?>.Success(EmprestimoViewModel.FromEntity(emprestimo));
        }

        public ResultViewModel<List<EmprestimoViewModel?>> GetAll()
        {
            var listaEmprestimos = _emprestimoRepository.GetAll();

            var lista = listaEmprestimos
                .Select(e => EmprestimoViewModel.FromEntity(e))
                .ToList();

            return ResultViewModel<List<EmprestimoViewModel?>>.Success(lista);
        }

    }
}
