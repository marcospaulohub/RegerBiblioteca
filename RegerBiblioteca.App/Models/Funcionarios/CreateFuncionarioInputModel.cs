using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.App.Models.Funcionarios
{
    public class CreateFuncionarioInputModel
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Cargo { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
