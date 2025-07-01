using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.App.Models.Exemplares
{
    public class CreateExemplarInputModel
    {
        public int LivroId { get; set; }
        public string CodigoBarras { get; set; }
        public string Localizacao { get; set; }
        public EstadoConservacao EstadoConservacao { get; set; }
    }
}
