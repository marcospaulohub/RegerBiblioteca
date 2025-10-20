using RegerBiblioteca.Core.Enums;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Core.ViewModels.Usuarios
{
    public class UpdateUsuarioInputModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
