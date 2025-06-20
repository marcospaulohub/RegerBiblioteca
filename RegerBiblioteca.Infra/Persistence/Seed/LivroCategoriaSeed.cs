using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class LivroCategoriaSeed
    {
        public static void SeedLivroCategorias(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroCategoria>().HasData(
                new LivroCategoria { Id = 1, LivroId = 1, CategoriaId = 2 },  // Fantasia
                new LivroCategoria { Id = 2, LivroId = 2, CategoriaId = 2 },  // Fantasia
                new LivroCategoria { Id = 3, LivroId = 3, CategoriaId = 7 },  // Policial
                new LivroCategoria { Id = 4, LivroId = 4, CategoriaId = 4 },  // Terror
                new LivroCategoria { Id = 5, LivroId = 5, CategoriaId = 3 },  // Ficção Científica
                new LivroCategoria { Id = 6, LivroId = 6, CategoriaId = 1 },  // Romance
                new LivroCategoria { Id = 7, LivroId = 7, CategoriaId = 5 },  // Suspense/Thriller
                new LivroCategoria { Id = 8, LivroId = 8, CategoriaId = 13 }  // História
            );
        }

    }
}
