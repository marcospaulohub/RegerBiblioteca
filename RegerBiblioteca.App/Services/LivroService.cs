using RegerBiblioteca.App.Models.Livros;
using RegerBiblioteca.App.Services.Interfaces;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.App.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        
        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public ResultViewModel<int> Create(CreateLivroInputModel model)
        {
            var livro = new Livro
            {
                Titulo = model.Titulo,
                ISBN = model.ISBN,
                AnoPublicacao = model.AnoPublicacao,
            };

            var livroId = _livroRepository.Insert(livro);
            
            if (livroId <= 0)
            {
                return ResultViewModel<int>.Error("Erro ao criar livro.");
            }

            return ResultViewModel<int>.Success(livroId);
        }

        public ResultViewModel Update(int id, UpdateLivroInputModel model)
        {
            var livro = _livroRepository.GetById(id);

            if (livro is null)
                return ResultViewModel.Error("Livro não encontrado.");

            livro.Titulo = model.Titulo;
            livro.ISBN = model.ISBN;
            livro.AnoPublicacao = model.AnoPublicacao;
            
            _livroRepository.Update(livro);

            return ResultViewModel.Success();
        }

        public ResultViewModel Delete(int id)
        {
            var livro = _livroRepository.GetById(id);

            if (livro is null)
                return ResultViewModel.Error("Livro não encontrado.");

            _livroRepository.Delete(livro);

            return ResultViewModel.Success();
        }

        public ResultViewModel<LivroViewModel?> GetById(int id)
        {
            var livro = _livroRepository.GetById(id);

            return livro is null ?
                ResultViewModel<LivroViewModel?>.Error("Livro não encontrado.") :
                ResultViewModel<LivroViewModel?>.Success(LivroViewModel.FromEntity(livro));
        }

        public ResultViewModel<List<LivroViewModel?>> GetAll()
        {
            var listaLivros = _livroRepository.GetAll();

            var lista = listaLivros
                .Select(l => LivroViewModel.FromEntity(l))
                .ToList();

            return ResultViewModel<List<LivroViewModel?>>.Success(lista);
        }
    }
}
