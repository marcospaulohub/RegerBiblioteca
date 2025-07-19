using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegerBiblioteca.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ExemplarId = table.Column<int>(type: "int", nullable: false),
                    DataReserva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExcluidoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Exemplar_ExemplarId",
                        column: x => x.ExemplarId,
                        principalTable: "Exemplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 15,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 16,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 17,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 18,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 19,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 20,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 7, 19, 14, 7, 23, 126, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ExemplarId",
                table: "Reserva",
                column: "ExemplarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_FuncionarioId",
                table: "Reserva",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioId",
                table: "Reserva",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 15,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 16,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 17,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 18,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 19,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 20,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Funcionario",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "LivroAutor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "LivroCategoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "CriadoEm",
                value: new DateTime(2025, 6, 20, 16, 1, 50, 628, DateTimeKind.Local).AddTicks(5769));
        }
    }
}
