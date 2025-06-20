using Microsoft.EntityFrameworkCore;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class ModelBuilderSeedExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
             modelBuilder.SeedCategorias();
             modelBuilder.SeedFuncionarios();
             modelBuilder.SeedAutores();
             modelBuilder.SeedLivros();
             modelBuilder.SeedLivroAutores();
             modelBuilder.SeedLivroCategorias();
        }
    }
}
