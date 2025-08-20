using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Categorias;

namespace RegerBiblioteca.App.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public ResultViewModel<int> Create(CreateCategoriaInputModel model)
        {
            var categoria = new Categoria
            {
                Nome = model.Nome,
                Descricao = model.Descricao
            };

            var categoriaId = _categoriaRepository.Insert(categoria);

            if (categoriaId <= 0)
                return ResultViewModel<int>.Error("Erro ao criar categoria.");

            return ResultViewModel<int>.Success(categoriaId);
        }

        public ResultViewModel Update(int id, UpdateCategoriaInputModel model)
        {
            var categoria = _categoriaRepository.GetById(id);
            if (categoria == null)
                return ResultViewModel.Error("Categoria não encontrada.");

            categoria.Nome = model.Nome;
            categoria.Descricao = model.Descricao;
            categoria.Genero = model.Genero;
            categoria.Ativo = model.Ativo;

            _categoriaRepository.Update(categoria);

            return ResultViewModel.Success();
        }
        public ResultViewModel Delete(int id)
        {
            var categoria = _categoriaRepository.GetById(id);
            if (categoria == null)
                return ResultViewModel.Error("Categoria não encontrada.");
            
            _categoriaRepository.Delete(categoria);
            
            return ResultViewModel.Success();
        }

        public ResultViewModel<CategoriaViewModel?> GetById(int id)
        {
            var categoria = _categoriaRepository.GetById(id);

            return categoria is null ?
                ResultViewModel<CategoriaViewModel?>.Error("Autor não encontrado.") :
                ResultViewModel<CategoriaViewModel?>.Success(CategoriaViewModel.FromEntity(categoria));
        }

        public ResultViewModel<List<CategoriaViewModel?>> GetAll()
        {
            var listCategoria = _categoriaRepository.GetAll();

            var list = listCategoria
                .Select(CategoriaViewModel.FromEntity)
                .ToList();

            return ResultViewModel<List<CategoriaViewModel?>>.Success(list);
        }
    }
}
