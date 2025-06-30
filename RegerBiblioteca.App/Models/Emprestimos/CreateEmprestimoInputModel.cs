using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.App.Models.Emprestimos
{
    public class CreateEmprestimoInputModel
    {
        public int FuncionarioId { get; set; }
        public int UsuarioId { get; set; }
        public int ExemplarId { get; set; }
    }
}
