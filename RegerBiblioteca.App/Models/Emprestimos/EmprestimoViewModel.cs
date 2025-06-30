using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.App.Models.Emprestimos
{
    public class EmprestimoViewModel
    {
        public EmprestimoViewModel(int funcionarioId, int usuarioId, int exemplarId)
        {
            FuncionarioId = funcionarioId;
            UsuarioId = usuarioId;
            ExemplarId = exemplarId;
        }

        public int FuncionarioId { get; set; }
        public int UsuarioId { get; set; }
        public int ExemplarId { get; set; }

        public static EmprestimoViewModel FromEntity(Emprestimo emprestimo)
        => new(emprestimo.FuncionarioId,
               emprestimo.UsuarioId,
               emprestimo.ExemplarId);
    }
}
