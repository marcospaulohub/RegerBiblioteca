using RegerBiblioteca.Core.Enums;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Core.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario() { }

        public Usuario(string nome, Email email, Senha senha, TipoUsuario tipoUsuario) : base()
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
    }
}
