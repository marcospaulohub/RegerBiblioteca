using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            throw new NotImplementedException();
        }
    }
}
