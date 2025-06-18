using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegerBiblioteca.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Ativo", "AtualizadoEm", "CriadoEm", "Descricao", "ExcluidoEm", "Genero", "Nome" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1693), "Histórias centradas em relacionamentos amorosos, com foco nas emoções e desenvolvimento dos personagens.", null, 1, "Romance" },
                    { 2, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1706), "Envolve mundos imaginários, magia, criaturas místicas e heróis épicos. Ex: O Senhor dos Anéis.", null, 1, "Fantasia" },
                    { 3, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1711), "Explora futuros possíveis, tecnologia avançada, vida em outros planetas, inteligência artificial, etc.", null, 1, "Ficção Científica" },
                    { 4, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1747), "Visa provocar medo ou tensão. Pode incluir elementos sobrenaturais, psicológicos ou monstros.", null, 1, "Terror/Horror" },
                    { 5, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1749), "Narrativas cheias de tensão e mistério, com reviravoltas e sensação de perigo constante.", null, 1, "Suspense/Thriller" },
                    { 6, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1750), "Histórias com exploração, ação e desafios físicos ou geográficos. Muitas vezes envolvem viagens e descobertas.", null, 1, "Aventura" },
                    { 7, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1751), "Gira em torno de investigações, assassinatos ou crimes, com detetives, policiais ou investigadores.", null, 1, "Policial/Crime" },
                    { 8, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1753), "Mostra sociedades futuristas \"perfeitas\" (utopias) ou opressoras e disfuncionais (distopias). Ex: 1984, Admirável Mundo Novo.", null, 1, "Distopia/Utopia" },
                    { 9, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1754), "Foca em dilemas humanos, conflitos emocionais e desenvolvimento pessoal.", null, 1, "Drama" },
                    { 10, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1755), "Escrita para crianças e adolescentes, muitas vezes com lições morais e linguagem acessível.", null, 1, "Literatura Infantojuvenil" },
                    { 11, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1756), "Histórias da vida real de pessoas (biografias escritas por terceiros ou autobiografias escritas pelo próprio autor).", null, 2, "Biografia/Autobiografia" },
                    { 12, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1757), "Oferece conselhos e reflexões para melhorar aspectos da vida pessoal, emocional ou profissional.", null, 2, "Autoajuda/Desenvolvimento Pessoal" },
                    { 13, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1759), "Relatos e análises sobre eventos históricos, períodos ou civilizações.", null, 2, "História" },
                    { 14, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1760), "Explicações e explorações sobre o mundo natural, física, biologia, astronomia, etc.", null, 2, "Ciência" },
                    { 15, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1762), "Discute questões existenciais, éticas, morais e o pensamento humano ao longo da história.", null, 2, "Filosofia" },
                    { 16, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1764), "Explora crenças, tradições religiosas, textos sagrados e espiritualidade em geral.", null, 2, "Religião/Espiritualidade" },
                    { 17, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1765), "Foca em empreendedorismo, mercado financeiro, administração e carreiras.", null, 2, "Negócios/Economia" },
                    { 18, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1766), "Livros para aprendizado de matérias escolares, técnicas ou idioma", null, 2, "Educação/Didáticos" },
                    { 19, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1767), "Receitas, técnicas de cozinha e cultura alimentar.", null, 2, "Culinária/Gastronomia" },
                    { 20, true, null, new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1768), "Relatos de experiências em outros países, guias turísticos e dicas de roteiros.", null, 2, "Viagens" }
                });

            migrationBuilder.InsertData(
                table: "Funcionario",
                columns: new[] { "Id", "AtualizadoEm", "Cargo", "CriadoEm", "DataAdmissao", "DataDemissao", "Email", "ExcluidoEm", "Matricula", "Nome", "Senha" },
                values: new object[] { 1, null, "Administrador", new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1939), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin@exemplo.com", null, "12345", "Admin", "****" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Funcionario",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
