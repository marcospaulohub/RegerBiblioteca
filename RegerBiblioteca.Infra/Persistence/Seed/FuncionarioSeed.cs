using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class FuncionarioSeed
    {
        public static void SeedFuncionarios(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario { Id = 1, Nome = "Admin", Email = Email.Criar("admin@exemplo.com"), Senha = Senha.Criar("senha123"), Cargo = "Administrador", Matricula = "12345", DataAdmissao = new DateTime(2020, 1, 1) }
                );
        }
    }
}
