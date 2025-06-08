using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Core.Entities
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
