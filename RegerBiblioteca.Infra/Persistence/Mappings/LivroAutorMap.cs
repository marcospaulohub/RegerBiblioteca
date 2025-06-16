using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class LivroAutorMap : IEntityTypeConfiguration<LivroAutor>
    {
        public void Configure(EntityTypeBuilder<LivroAutor> builder)
        {
            builder
                .ToTable("LivroAutor");

            builder.HasKey(la => la.Id);

            builder
                .HasOne(la => la.Livro)
                .WithMany(l => l.Autores)
                .HasForeignKey(la => la.LivroId);

            builder
                .HasOne(la => la.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(la => la.AutorId);
        }
    }
}
