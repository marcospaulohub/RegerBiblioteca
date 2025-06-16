using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder
                .ToTable("Emprestimo");

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.FuncionarioId)
                .IsRequired();

            builder
                .HasOne(e => e.Funcionario)
                .WithMany()
                .HasForeignKey(e => e.FuncionarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.UsuarioId)
                .IsRequired();

            builder
                .HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.ExemplarId)
                .IsRequired();

            builder
                .HasOne(e => e.Exemplar)
                .WithMany()
                .HasForeignKey(e => e.ExemplarId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
