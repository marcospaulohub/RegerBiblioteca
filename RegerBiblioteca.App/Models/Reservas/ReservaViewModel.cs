using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.App.Models.Reservas
{
    public class ReservaViewModel
    {
        public ReservaViewModel(int funcionarioId, int usuarioId, int exemplarId, DateTime dataReserva, StatusReserva status)
        {
            FuncionarioId = funcionarioId;
            UsuarioId = usuarioId;
            ExemplarId = exemplarId;
            DataReserva = dataReserva;
            Status = status;
        }

        public int FuncionarioId { get; set; }
        public int UsuarioId { get; set; }
        public int ExemplarId { get; set; }
        public DateTime DataReserva { get; set; }
        public StatusReserva Status { get; set; }

        public static ReservaViewModel FromEntity(Reserva reserva)
        {
            return new ReservaViewModel(
                reserva.FuncionarioId,
                reserva.UsuarioId,
                reserva.ExemplarId,
                reserva.DataReserva,
                reserva.Status);
        }
    }
}
