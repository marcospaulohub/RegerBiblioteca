using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Core.ViewModels.Usuarios
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(int id, string nome, Email email, Senha senha, TipoUsuario tipoUsuario)
        {
            Id = id;
            Nome = nome;
            Email = email.ToString();
            Senha = senha.ToString();
            TipoUsuario = tipoUsuario;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public static UsuarioViewModel FromEntity(Usuario usuario)
        {
            return new UsuarioViewModel(
                usuario.Id,
                usuario.Nome,
                usuario.Email,
                usuario.Senha,
                usuario.TipoUsuario
            );
        }
    }
}
