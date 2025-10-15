using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder
                .ToTable("Funcionario");

            builder
                .HasKey(f => f.Id);

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder
                .Property(f => f.Email)
                .HasConversion(
                    v => v.ToString(),
                    v => Email.Criar(v))
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder
                .Property(f => f.Senha)
                .HasConversion(
                    v => Senha.ComputeHash(v.Valor),
                    v => Senha.Criar(v))
                .IsRequired()
                .HasColumnType("varchar(max)");

            builder
                .Property(f => f.Cargo)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder
                .Property(f => f.Matricula)
                .IsRequired()
                .HasColumnType("varchar(20)");
        }
    }
}
