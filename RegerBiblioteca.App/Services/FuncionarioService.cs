using RegerBiblioteca.App.Models.Funcionarios;
using RegerBiblioteca.App.Services.Interfaces;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.App.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public ResultViewModel<int> Create(CreateFuncionarioInputModel model)
        {
            var funcionario = new Funcionario
            {
                Nome = model.Nome,
                Email = model.Email,
                Senha = model.Senha,
                Cargo = model.Cargo,
                Matricula = model.Matricula,
                DataAdmissao = model.DataAdmissao
            };

            var funcionarioId = _funcionarioRepository.Insert(funcionario);

            if (funcionarioId <= 0)
            {
                return ResultViewModel<int>.Error("Erro ao criar funcionário.");
            }

            return ResultViewModel<int>.Success(funcionarioId);
        }

        public ResultViewModel Update(int id, UpdateFuncionarioInputModel model)
        {
            var funcionario = _funcionarioRepository.GetById(id);

            if (funcionario is null)
                return ResultViewModel.Error("Funcionário não encontrado.");

            funcionario.Nome = model.Nome;
            funcionario.Email = model.Email;
            funcionario.Senha = model.Senha;
            funcionario.Cargo = model.Cargo;
            funcionario.Matricula = model.Matricula;
            funcionario.DataAdmissao = model.DataAdmissao;
            
            _funcionarioRepository.Update(funcionario);

            return ResultViewModel.Success();

        }

        public ResultViewModel Delete(int id)
        {
            var funcionario = _funcionarioRepository.GetById(id);

            if (funcionario is null)
                return ResultViewModel.Error("Funcionário não encontrado.");

            _funcionarioRepository.Delete(funcionario);
            
            return ResultViewModel.Success();
        }

        public ResultViewModel<FuncionarioViewModel?> GetById(int id)
        {
            var funcionario = _funcionarioRepository.GetById(id);

            return funcionario is null ? 
                ResultViewModel<FuncionarioViewModel?>.Error("Funcionário não encontrado.") : 
                ResultViewModel<FuncionarioViewModel?>.Success(FuncionarioViewModel.FromEntity(funcionario));
        }

        public ResultViewModel<List<FuncionarioViewModel?>> GetAll()
        {
            var listaFuncionarios = _funcionarioRepository.GetAll();

            var lista = listaFuncionarios
                .Select(f => FuncionarioViewModel.FromEntity(f))
                .ToList();

            return ResultViewModel<List<FuncionarioViewModel?>>.Success(lista);
        }
    }
}
