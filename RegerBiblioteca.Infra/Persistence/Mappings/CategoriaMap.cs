using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
               .ToTable("Categoria");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(200)");

            builder
                .Property(c => c.Descricao)
                .HasColumnType("varchar(500)");
        }
    }
}
