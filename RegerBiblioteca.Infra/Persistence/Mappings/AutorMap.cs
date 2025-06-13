using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder
                .ToTable("Autor");

            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Nome)
                .HasColumnType("varchar(200)");

            builder
                .Property(a => a.Nacionalidade)
                .HasColumnType("varchar(100)");

            builder
                .Property(a => a.Biografia)
                .HasColumnType("varchar(max)");

            builder
                .Property(a => a.FotoUrl)
                .HasColumnType("varchar(200)");

            builder
                .Property(a => a.SiteUrl)
                .HasColumnType("varchar(200)");
        }
    }
}
