using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegerBiblioteca.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedAutores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "AtualizadoEm", "Biografia", "CriadoEm", "DataFalecimento", "DataNascimento", "ExcluidoEm", "FotoUrl", "Nacionalidade", "Nome", "SiteUrl" },
                values: new object[,]
                {
                    { 1, null, "Autora da série Harry Potter.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4634), null, new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/jk_rowling.jpg", "Britânica", "J.K. Rowling", "https://www.jkrowling.com/" },
                    { 2, null, "Autor da série As Crônicas de Gelo e Fogo.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4640), null, new DateTime(1948, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/george_rr_martin.jpg", "Americano", "George R.R. Martin", "https://www.georgerrmartin.com/" },
                    { 3, null, "Rainha do crime, famosa por seus romances policiais.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4643), new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/agatha_christie.jpg", "Britânica", "Agatha Christie", "https://www.agathachristie.com/" },
                    { 4, null, "Mestre do terror moderno, autor de O Iluminado.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4645), null, new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/stephen_king.jpg", "Americano", "Stephen King", "https://www.stephenking.com/" },
                    { 5, null, "Pioneiro da ficção científica, criador das Três Leis da Robótica.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4647), new DateTime(1992, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1920, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/isaac_asimov.jpg", "Americano", "Isaac Asimov", "https://asimovonline.com/" },
                    { 6, null, "Autora clássica de romances como Orgulho e Preconceito.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4649), new DateTime(1817, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/jane_austen.jpg", "Britânica", "Jane Austen", "https://www.janeausten.org/" },
                    { 7, null, "Autor de thrillers como O Código Da Vinci.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4652), null, new DateTime(1964, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/dan_brown.jpg", "Americano", "Dan Brown", "https://danbrown.com/" },
                    { 8, null, "Historiador e autor de Sapiens: Uma Breve História da Humanidade.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4654), null, new DateTime(1976, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/yuval_harari.jpg", "Israelense", "Yuval Noah Harari", "https://www.ynharari.com/" },
                    { 9, null, "Uma das maiores escritoras brasileiras, conhecida por sua prosa introspectiva.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4655), new DateTime(1977, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1920, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/clarice_lispector.jpg", "Brasileira", "Clarice Lispector", "https://claricelispector.ims.com.br/" },
                    { 10, null, "Considerado o maior escritor brasileiro, autor de Dom Casmurro.", new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4658), new DateTime(1908, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1839, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://example.com/machado_de_assis.jpg", "Brasileiro", "Machado de Assis", "https://machadodeassis.net/" }
                });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 15,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 16,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 17,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 18,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 19,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 20,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 19, 22, 53, 40, 767, DateTimeKind.Local).AddTicks(4474));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 15,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 16,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 17,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 18,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 19,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 20,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1939));
        }
    }
}
