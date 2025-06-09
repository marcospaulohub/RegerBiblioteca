using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            throw new NotImplementedException();
        }
    }
}
