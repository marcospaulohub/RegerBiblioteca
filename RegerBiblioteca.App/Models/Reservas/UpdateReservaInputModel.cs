using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.App.Models.Reservas
{
    public class UpdateReservaInputModel
    {
        public int FuncionarioId { get; set; }
        public int UsuarioId { get; set; }
        public int ExemplarId { get; set; }
        public DateTime DataReserva { get; set; }
        public StatusReserva Status { get; set; }
    }
}
