using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Exemplar : BaseEntity
    {
        public Exemplar() { }

        public Exemplar(int livroId, string codigoBarras, string localizacao, EstadoConservacao estadoConservacao) : base()
        {
            LivroId = livroId;
            CodigoBarras = codigoBarras;
            Localizacao = localizacao;
            EstadoConservacao = estadoConservacao;
        }

        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public string CodigoBarras { get; set; }
        public string Localizacao { get; set; }
        public EstadoConservacao EstadoConservacao { get; set; }
    }
}