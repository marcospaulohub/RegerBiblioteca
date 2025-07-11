using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.App.Models.Usuarios
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nome, Email email, Senha senha, TipoUsuario tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public static UsuarioViewModel FromEntity(Usuario usuario)
        {
            return new UsuarioViewModel(
                usuario.Nome,
                usuario.Email,
                usuario.Senha,
                usuario.TipoUsuario
            );
        }
    }
}
