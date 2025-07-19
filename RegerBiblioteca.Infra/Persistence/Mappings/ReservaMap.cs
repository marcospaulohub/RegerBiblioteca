using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder
                .ToTable("Reserva");

            builder
                .HasKey(r => r.Id);

            builder
                .Property(r => r.FuncionarioId)
                .IsRequired();

            builder
                .HasOne(r => r.Funcionario)
                .WithMany()
                .HasForeignKey(r => r.FuncionarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(r => r.UsuarioId)
                .IsRequired();

            builder
                .HasOne(r => r.Usuario)
                .WithMany()
                .HasForeignKey(r => r.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(r => r.ExemplarId)
                .IsRequired();

            builder
                .HasOne(r => r.Exemplar)
                .WithMany()
                .HasForeignKey(r => r.ExemplarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(r => r.DataReserva)
                .IsRequired();

            builder
                .Property(r => r.Status)
                .IsRequired();

        }
    }
}
