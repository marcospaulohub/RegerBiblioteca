using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class ExemplarMap : IEntityTypeConfiguration<Exemplar>
    {
        public void Configure(EntityTypeBuilder<Exemplar> builder)
        {
            builder
               .ToTable("Exemplar");

            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.CodigoBarras)
                .HasColumnType("varchar(200)");

            builder
                .Property(e => e.Localizacao)
                .HasColumnType("varchar(20)");
        }
    }
}
