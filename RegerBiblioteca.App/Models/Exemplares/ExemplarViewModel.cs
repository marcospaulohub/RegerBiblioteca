using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.App.Models.Exemplares
{
    public class ExemplarViewModel
    {
        public ExemplarViewModel(int livroId, string codigoBarras, string localizacao, EstadoConservacao estadoConservacao)
        {
            LivroId = livroId;
            CodigoBarras = codigoBarras;
            Localizacao = localizacao;
            EstadoConservacao = estadoConservacao;
        }

        public int LivroId { get; set; }
        public string CodigoBarras { get; set; }
        public string Localizacao { get; set; }
        public EstadoConservacao EstadoConservacao { get; set; }

        public static ExemplarViewModel FromEntity(Exemplar exemplar)
        {
            return new ExemplarViewModel(
                exemplar.LivroId,
                exemplar.CodigoBarras,
                exemplar.Localizacao,
                exemplar.EstadoConservacao);
        }
    }
}
