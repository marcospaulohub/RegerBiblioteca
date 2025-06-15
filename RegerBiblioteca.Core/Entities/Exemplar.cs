using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Exemplar : BaseEntity
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public string CodigoBarras { get; set; }
        public string Localizacao { get; set; }
        public EstadoConservacao EstadoConservacao { get; set; }
    }
}