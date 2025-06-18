using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Infra.Persistence.Seed
{
    public static class CategoriaSeed
    {
        public static void SeedCategorias(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nome = "Romance", Descricao = "Histórias centradas em relacionamentos amorosos, com foco nas emoções e desenvolvimento dos personagens.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 2, Nome = "Fantasia", Descricao = "Envolve mundos imaginários, magia, criaturas místicas e heróis épicos. Ex: O Senhor dos Anéis.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 3, Nome = "Ficção Científica", Descricao = "Explora futuros possíveis, tecnologia avançada, vida em outros planetas, inteligência artificial, etc.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 4, Nome = "Terror/Horror", Descricao = "Visa provocar medo ou tensão. Pode incluir elementos sobrenaturais, psicológicos ou monstros.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 5, Nome = "Suspense/Thriller", Descricao = "Narrativas cheias de tensão e mistério, com reviravoltas e sensação de perigo constante.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 6, Nome = "Aventura", Descricao = "Histórias com exploração, ação e desafios físicos ou geográficos. Muitas vezes envolvem viagens e descobertas.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 7, Nome = "Policial/Crime", Descricao = "Gira em torno de investigações, assassinatos ou crimes, com detetives, policiais ou investigadores.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 8, Nome = "Distopia/Utopia", Descricao = "Mostra sociedades futuristas \"perfeitas\" (utopias) ou opressoras e disfuncionais (distopias). Ex: 1984, Admirável Mundo Novo.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 9, Nome = "Drama", Descricao = "Foca em dilemas humanos, conflitos emocionais e desenvolvimento pessoal.", Genero = Genero.Ficcao, Ativo = true },
                new Categoria { Id = 10, Nome = "Literatura Infantojuvenil", Descricao = "Escrita para crianças e adolescentes, muitas vezes com lições morais e linguagem acessível.", Genero = Genero.Ficcao, Ativo = true },

                new Categoria { Id = 11, Nome = "Biografia/Autobiografia", Descricao = "Histórias da vida real de pessoas (biografias escritas por terceiros ou autobiografias escritas pelo próprio autor).", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 12, Nome = "Autoajuda/Desenvolvimento Pessoal", Descricao = "Oferece conselhos e reflexões para melhorar aspectos da vida pessoal, emocional ou profissional.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 13, Nome = "História", Descricao = "Relatos e análises sobre eventos históricos, períodos ou civilizações.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 14, Nome = "Ciência", Descricao = "Explicações e explorações sobre o mundo natural, física, biologia, astronomia, etc.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 15, Nome = "Filosofia", Descricao = "Discute questões existenciais, éticas, morais e o pensamento humano ao longo da história.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 16, Nome = "Religião/Espiritualidade", Descricao = "Explora crenças, tradições religiosas, textos sagrados e espiritualidade em geral.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 17, Nome = "Negócios/Economia", Descricao = "Foca em empreendedorismo, mercado financeiro, administração e carreiras.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 18, Nome = "Educação/Didáticos", Descricao = "Livros para aprendizado de matérias escolares, técnicas ou idioma", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 19, Nome = "Culinária/Gastronomia", Descricao = "Receitas, técnicas de cozinha e cultura alimentar.", Genero = Genero.NaoFiccao, Ativo = true },
                new Categoria { Id = 20, Nome = "Viagens", Descricao = "Relatos de experiências em outros países, guias turísticos e dicas de roteiros.", Genero = Genero.NaoFiccao, Ativo = true }
            );
        }
    }
}
