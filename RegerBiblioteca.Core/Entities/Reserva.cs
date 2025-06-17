using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Reserva : BaseEntity
    {
        public Reserva() { }

        public Reserva(int funcionarioId, int usuarioId, int exemplarId, DateTime dataReserva) : base()
        {
            FuncionarioId = funcionarioId;
            UsuarioId = usuarioId;
            ExemplarId = exemplarId;
            DataReserva = dataReserva;

            Status = StatusReserva.Pendente;
        }

        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int ExemplarId { get; set; }
        public Exemplar Exemplar { get; set; }

        public DateTime DataReserva { get; set; }
        public StatusReserva Status { get; set; }
    }
}
