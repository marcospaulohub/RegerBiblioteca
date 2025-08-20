using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Autores;

namespace RegerBiblioteca.App.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository; 
        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public ResultViewModel<int> Create(CreateAutorInputModel model)
        {
            var autor = new Autor
            {
                Nome = model.Nome,
                Nacionalidade = model.Nacionalidade,
                DataNascimento = model.DataNascimento,
                DataFalecimento = model.DataFalecimento,
                Biografia = model.Biografia,
                FotoUrl = model.FotoUrl,
                SiteUrl = model.SiteUrl
            };

            var autorId = _autorRepository.Insert(autor);

            if (autorId <= 0)
                return ResultViewModel<int>.Error("Erro ao criar autor.");

            return ResultViewModel<int>.Success(autorId);
        }
        public ResultViewModel Update(int id, UpdateAutorInputModel model)
        {
            var autor = _autorRepository.GetById(id);
            if (autor == null)
                return ResultViewModel.Error("Autor não encontrado.");

            _autorRepository.Update(autor);

            return ResultViewModel.Success();
        }

        public ResultViewModel Delete(int id)
        {
            var autor = _autorRepository.GetById(id);
            if (autor == null)
                return ResultViewModel.Error("Autor não encontrado.");

            _autorRepository.Delete(autor);

            return ResultViewModel.Success();
        }
        public ResultViewModel<AutorViewModel?> GetById(int id)
        {
            var autor = _autorRepository.GetById(id);

            return autor is null ?
                ResultViewModel<AutorViewModel?>.Error("Autor não encontrado.") :
                ResultViewModel<AutorViewModel?>.Success(AutorViewModel.FromEntity(autor));
        }

        public ResultViewModel<List<AutorViewModel?>> GetAll()
        {
            var listaAutores = _autorRepository.GetAll();

            var list = listaAutores
                .Select(AutorViewModel.FromEntity)
                .ToList();

            return ResultViewModel<List<AutorViewModel?>>.Success(list);
        }


    }
}
