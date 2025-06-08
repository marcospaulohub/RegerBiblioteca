using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Reserva : BaseEntity
    {
        public int UsuarioId { get; set; }
        Usuario Usuario { get; set; }

        public int ExemplarId { get; set; }
        public Exemplar Exemplar { get; set; }

        public DateTime DataReserva { get; set; }
        public StatusReserva Status { get; set; }
    }
}
