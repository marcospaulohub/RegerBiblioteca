using RegerBiblioteca.App.Models.Exemplares;
using RegerBiblioteca.App.Services.Interfaces;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.App.Services
{
    public class ExemplarService : IExemplarService
    {
        private readonly IExemplarRepository _exemplarRepository;  

        public ExemplarService(IExemplarRepository exemplarRepository)
        {
            _exemplarRepository = exemplarRepository;
        }

        public ResultViewModel<int> Create(CreateExemplarInputModel model)
        {
            var exemplar = new Exemplar
            {
                LivroId = model.LivroId,
                CodigoBarras = model.CodigoBarras,
                Localizacao = model.Localizacao,
                EstadoConservacao = model.EstadoConservacao
            };

            var exemplarId = _exemplarRepository.Insert(exemplar);
            
            if (exemplarId <= 0)
            {
                return ResultViewModel<int>.Error("Erro ao criar exemplar.");
            }

            return ResultViewModel<int>.Success(exemplarId);
        }

        public ResultViewModel Update(int id, UpdateExemplarInputModel model)
        {
            var exemplar = _exemplarRepository.GetById(id);

            if (exemplar is null)
                return ResultViewModel.Error("Exemplar não encontrado.");

            exemplar.LivroId = model.LivroId;
            exemplar.CodigoBarras = model.CodigoBarras;
            exemplar.Localizacao = model.Localizacao;
            exemplar.EstadoConservacao = model.EstadoConservacao;
            
            _exemplarRepository.Update(exemplar);
            
            return ResultViewModel.Success();
        }

        public ResultViewModel Delete(int id)
        {
            var exemplar = _exemplarRepository.GetById(id);

            if (exemplar is null)
                return ResultViewModel.Error("Exemplar não encontrado.");

            _exemplarRepository.Delete(exemplar);

            return ResultViewModel.Success();
        }

        public ResultViewModel<ExemplarViewModel?> GetById(int id)
        {
            var exemplar = _exemplarRepository.GetById(id);

            return exemplar is null ?
                ResultViewModel<ExemplarViewModel?>.Error("Exemplar não encontrado.") :
                ResultViewModel<ExemplarViewModel?>.Success(ExemplarViewModel.FromEntity(exemplar));

        }

        public ResultViewModel<List<ExemplarViewModel?>> GetAll()
        {
            var listaExemplares = _exemplarRepository.GetAll();

            var lista = listaExemplares
                .Select(e => ExemplarViewModel.FromEntity(e))
                .ToList();

            return ResultViewModel<List<ExemplarViewModel?>>.Success(lista);
        }

    }
}
