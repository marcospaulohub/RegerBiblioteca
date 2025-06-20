using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class LivroSeed
    {
        public static void SeedLivros(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().HasData(
                new Livro
                {
                    Id = 1,
                    Titulo = "Harry Potter e a Pedra Filosofal",
                    ISBN = "978-8532511010",
                    AnoPublicacao = 1997
                },
                new Livro
                {
                    Id = 2,
                    Titulo = "As Crônicas de Gelo e Fogo: A Guerra dos Tronos",
                    ISBN = "978-8576572001",
                    AnoPublicacao = 1996
                },
                new Livro
                {
                    Id = 3,
                    Titulo = "Assassinato no Expresso do Oriente",
                    ISBN = "978-8501401600",
                    AnoPublicacao = 1934
                },
                new Livro
                {
                    Id = 4,
                    Titulo = "O Iluminado",
                    ISBN = "978-8551001007",
                    AnoPublicacao = 1977
                },
                new Livro
                {
                    Id = 5,
                    Titulo = "Eu, Robô",
                    ISBN = "978-8532523037",
                    AnoPublicacao = 1950
                },
                new Livro
                {
                    Id = 6,
                    Titulo = "Orgulho e Preconceito",
                    ISBN = "978-8503012262",
                    AnoPublicacao = 1813
                },
                new Livro
                {
                    Id = 7,
                    Titulo = "O Código Da Vinci",
                    ISBN = "978-8575422391",
                    AnoPublicacao = 2003
                },
                new Livro
                {
                    Id = 8,
                    Titulo = "Sapiens: Uma Breve História da Humanidade",
                    ISBN = "978-8535925197",
                    AnoPublicacao = 2011
                }
            );
        }

    }
}
