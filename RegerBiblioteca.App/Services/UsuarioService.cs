using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;
using RegerBiblioteca.Core.Services;
using RegerBiblioteca.Core.ViewModels;
using RegerBiblioteca.Core.ViewModels.Usuarios;

namespace RegerBiblioteca.App.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public ResultViewModel<int> Create(CreateUsuarioInputModel model)
        {
            var usuario = new Usuario
            {
                Nome = model.Nome,
                Email = model.Email,
                Senha = model.Senha,
                TipoUsuario = model.TipoUsuario
            };

            var usuarioId = _usuarioRepository.Insert(usuario); 
            if (usuarioId <= 0)
            {
                return ResultViewModel<int>.Error("Erro ao criar usuário.");
            }

            return ResultViewModel<int>.Success(usuarioId);
        }

        public ResultViewModel Update(int id, UpdateUsuarioInputModel model)
        {
            var usuario = _usuarioRepository.GetById(id);

            if (usuario is null)
                return ResultViewModel.Error("Usuário não encontrado.");

            usuario.Nome = model.Nome;
            usuario.Email = model.Email;
            usuario.Senha = model.Senha;
            usuario.TipoUsuario = model.TipoUsuario;
            
            _usuarioRepository.Update(usuario);
            
            return ResultViewModel.Success();
        }

        public ResultViewModel Delete(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            if (usuario is null)
                return ResultViewModel.Error("Usuário não encontrado.");

            _usuarioRepository.Delete(usuario);

            return ResultViewModel.Success();
        }

        public ResultViewModel<UsuarioViewModel?> GetById(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            return usuario is null 
                ? ResultViewModel<UsuarioViewModel?>.Error("Usuário não encontrado.")
                : ResultViewModel<UsuarioViewModel?>.Success(UsuarioViewModel.FromEntity(usuario));
        }

        public ResultViewModel<List<UsuarioViewModel?>> GetAll()
        {
            var listaUsuarios = _usuarioRepository.GetAll();

            var lista = listaUsuarios
                .Select(u => UsuarioViewModel.FromEntity(u))
                .ToList();

            return ResultViewModel<List<UsuarioViewModel?>>.Success(lista);
        }
    }
}
