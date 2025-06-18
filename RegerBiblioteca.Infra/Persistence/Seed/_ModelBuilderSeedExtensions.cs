using Microsoft.EntityFrameworkCore;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class ModelBuilderSeedExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
             modelBuilder.SeedCategorias();
             modelBuilder.SeedFuncionarios();
        }
    }
}
