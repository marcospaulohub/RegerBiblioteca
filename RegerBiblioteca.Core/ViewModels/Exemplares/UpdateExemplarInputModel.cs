using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.ViewModels.Exemplares
{
    public class UpdateExemplarInputModel
    {
        public int LivroId { get; set; }
        public string CodigoBarras { get; set; }
        public string Localizacao { get; set; }
        public EstadoConservacao EstadoConservacao { get; set; }
    }
}
