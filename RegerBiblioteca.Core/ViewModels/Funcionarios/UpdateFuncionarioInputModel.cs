using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Core.ViewModels.Funcionarios
{
    public class UpdateFuncionarioInputModel
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Cargo { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
