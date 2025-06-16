using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class LivroCategoriaMap : IEntityTypeConfiguration<LivroCategoria>
    {
        public void Configure(EntityTypeBuilder<LivroCategoria> builder)
        {
            builder
                .ToTable("LivroCategoria");

            builder
                .HasKey(lc => lc.Id);

            builder
                .HasOne(lc => lc.Livro)
                .WithMany(l => l.Categorias)
                .HasForeignKey(lc => lc.LivroId);

            builder
                .HasOne(lc => lc.Categoria)
                .WithMany(c => c.Livros)
                .HasForeignKey(lc => lc.CategoriaId);
        }
    }
}
