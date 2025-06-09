using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            throw new NotImplementedException();
        }
    }
}
