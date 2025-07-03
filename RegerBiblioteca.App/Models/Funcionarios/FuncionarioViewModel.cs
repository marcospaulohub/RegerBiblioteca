using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.App.Models.Funcionarios
{
    public class FuncionarioViewModel
    {
        public FuncionarioViewModel(string nome, Email email, Senha senha, string cargo, string matricula, DateTime dataAdmissao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cargo = cargo;
            Matricula = matricula;
            DataAdmissao = dataAdmissao;
        }

        public string Nome { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Cargo { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }

        public static FuncionarioViewModel FromEntity(Funcionario funcionario)
        {
            return new FuncionarioViewModel(
                funcionario.Nome,
                funcionario.Email,
                funcionario.Senha,
                funcionario.Cargo,
                funcionario.Matricula,
                funcionario.DataAdmissao);
        }

    }
}
