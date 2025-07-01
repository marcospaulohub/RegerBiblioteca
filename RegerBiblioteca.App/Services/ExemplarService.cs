using RegerBiblioteca.App.Models.Exemplares;
using RegerBiblioteca.App.Services.Interfaces;
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
            throw new NotImplementedException();
        }
        public ResultViewModel Update(int id, UpdateExemplarInputModel model)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel<ExemplarViewModel?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel<List<ExemplarViewModel?>> GetAll()
        {
            throw new NotImplementedException();
        }


    }
}
