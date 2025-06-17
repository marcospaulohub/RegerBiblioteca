using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Emprestimo : BaseEntity
    {
        private const int PERIODO_EMPRESTIMO = 14;

        public Emprestimo() { }

        public Emprestimo(int funcionarioId, int usuarioId, int exemplarId) : base()
        {
            FuncionarioId = funcionarioId;
            UsuarioId = usuarioId;
            ExemplarId = exemplarId;

            DataEmprestimo = DateTime.Today;
            DataDevolucao = ObterDataValidaParaRetorno();
        }

        public int FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }


        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        

        public int ExemplarId { get; set; }
        public Exemplar? Exemplar { get; set; }


        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public StatusEmprestimo Status { get; set; }

        private DateTime ObterDataValidaParaRetorno()
        {
            var dataParaRetorno = DateTime.Today.AddDays(PERIODO_EMPRESTIMO);

            if (dataParaRetorno.DayOfWeek == DayOfWeek.Saturday) dataParaRetorno = dataParaRetorno.AddDays(2);

            if (dataParaRetorno.DayOfWeek == DayOfWeek.Sunday) dataParaRetorno = dataParaRetorno.AddDays(1);

            return dataParaRetorno;
        }
    }
}
