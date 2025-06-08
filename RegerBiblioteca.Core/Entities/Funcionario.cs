using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Core.Entities
{
    public class Funcionario : BaseEntity
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Cargo { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
    }
}
