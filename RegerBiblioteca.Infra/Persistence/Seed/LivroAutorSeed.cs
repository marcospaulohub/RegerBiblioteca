using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class LivroAutorSeed
    {
        public static void SeedLivroAutores(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroAutor>().HasData(
                new LivroAutor { Id = 1, LivroId = 1, AutorId = 1 }, // J.K. Rowling
                new LivroAutor { Id = 2, LivroId = 2, AutorId = 2 }, // George R.R. Martin
                new LivroAutor { Id = 3, LivroId = 3, AutorId = 3 }, // Agatha Christie
                new LivroAutor { Id = 4, LivroId = 4, AutorId = 4 }, // Stephen King
                new LivroAutor { Id = 5, LivroId = 5, AutorId = 5 }, // Isaac Asimov
                new LivroAutor { Id = 6, LivroId = 6, AutorId = 6 }, // Jane Austen
                new LivroAutor { Id = 7, LivroId = 7, AutorId = 7 }, // Dan Brown
                new LivroAutor { Id = 8, LivroId = 8, AutorId = 8 }  // Yuval Harari
            );
        }

    }
}
