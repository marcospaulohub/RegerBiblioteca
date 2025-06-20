using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class AutorSeed
    {
        public static void SeedAutores(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id = 1, Nome = "J.K. Rowling", Nacionalidade = "Britânica", DataNascimento = new DateTime(1965, 7, 31), Biografia = "Autora da série Harry Potter.", FotoUrl = "https://example.com/jk_rowling.jpg", SiteUrl = "https://www.jkrowling.com/" },
                new Autor { Id = 2, Nome = "George R.R. Martin", Nacionalidade = "Americano", DataNascimento = new DateTime(1948, 9, 20), Biografia = "Autor da série As Crônicas de Gelo e Fogo.", FotoUrl = "https://example.com/george_rr_martin.jpg", SiteUrl = "https://www.georgerrmartin.com/" },
                new Autor { Id = 3, Nome = "Agatha Christie", Nacionalidade = "Britânica", DataNascimento = new DateTime(1890, 9, 15), DataFalecimento = new DateTime(1976, 1, 12), Biografia = "Rainha do crime, famosa por seus romances policiais.", FotoUrl = "https://example.com/agatha_christie.jpg", SiteUrl = "https://www.agathachristie.com/" },
                new Autor { Id = 4, Nome = "Stephen King", Nacionalidade = "Americano", DataNascimento = new DateTime(1947, 9, 21), Biografia = "Mestre do terror moderno, autor de O Iluminado.", FotoUrl = "https://example.com/stephen_king.jpg", SiteUrl = "https://www.stephenking.com/" },
                new Autor { Id = 5, Nome = "Isaac Asimov", Nacionalidade = "Americano", DataNascimento = new DateTime(1920, 1, 2), DataFalecimento = new DateTime(1992, 4, 6), Biografia = "Pioneiro da ficção científica, criador das Três Leis da Robótica.", FotoUrl = "https://example.com/isaac_asimov.jpg", SiteUrl = "https://asimovonline.com/" },
                new Autor { Id = 6, Nome = "Jane Austen", Nacionalidade = "Britânica", DataNascimento = new DateTime(1775, 12, 16), DataFalecimento = new DateTime(1817, 7, 18), Biografia = "Autora clássica de romances como Orgulho e Preconceito.", FotoUrl = "https://example.com/jane_austen.jpg", SiteUrl = "https://www.janeausten.org/" },
                new Autor { Id = 7, Nome = "Dan Brown", Nacionalidade = "Americano", DataNascimento = new DateTime(1964, 6, 22), Biografia = "Autor de thrillers como O Código Da Vinci.", FotoUrl = "https://example.com/dan_brown.jpg", SiteUrl = "https://danbrown.com/" },
                new Autor { Id = 8, Nome = "Yuval Noah Harari", Nacionalidade = "Israelense", DataNascimento = new DateTime(1976, 2, 24), Biografia = "Historiador e autor de Sapiens: Uma Breve História da Humanidade.", FotoUrl = "https://example.com/yuval_harari.jpg", SiteUrl = "https://www.ynharari.com/" },
                new Autor { Id = 9, Nome = "Clarice Lispector", Nacionalidade = "Brasileira", DataNascimento = new DateTime(1920, 12, 10), DataFalecimento = new DateTime(1977, 12, 9), Biografia = "Uma das maiores escritoras brasileiras, conhecida por sua prosa introspectiva.", FotoUrl = "https://example.com/clarice_lispector.jpg", SiteUrl = "https://claricelispector.ims.com.br/" },
                new Autor { Id = 10, Nome = "Machado de Assis", Nacionalidade = "Brasileiro", DataNascimento = new DateTime(1839, 6, 21), DataFalecimento = new DateTime(1908, 9, 29), Biografia = "Considerado o maior escritor brasileiro, autor de Dom Casmurro.", FotoUrl = "https://example.com/machado_de_assis.jpg", SiteUrl = "https://machadodeassis.net/" }
            );
        }
    }
}
