using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            throw new NotImplementedException();
        }
    }
}
