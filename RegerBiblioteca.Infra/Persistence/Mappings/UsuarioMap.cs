using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.ValueObjects;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .ToTable("Usuario");

            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder
                .Property(u => u.Email)
                .HasConversion(
                    v => v.ToString(),
                    v => Email.Criar(v))
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder
                .Property(u => u.Senha)
                .HasConversion(
                    v => Senha.ComputeHash(v.Valor),
                    v => Senha.Criar(v))
                .IsRequired()
                .HasColumnType("varchar(max)");
        }
    }
}
