using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder
                .ToTable("Livro");

            builder
                .HasKey(l => l.Id);

            builder
                .Property(l => l.Titulo)
                .HasColumnType("varchar(100)");

            builder
                .Property(l => l.ISBN)
                .HasColumnType("varchar(50)");
        }
    }
}
