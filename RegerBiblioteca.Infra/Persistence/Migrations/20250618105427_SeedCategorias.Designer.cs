﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegerBiblioteca.Infra.Persistence;

#nullable disable

namespace RegerBiblioteca.Infra.Persistence.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20250618105427_SeedCategorias")]
    partial class SeedCategorias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Biografia")
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFalecimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("SiteUrl")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Autor", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1693),
                            Descricao = "Histórias centradas em relacionamentos amorosos, com foco nas emoções e desenvolvimento dos personagens.",
                            Genero = 1,
                            Nome = "Romance"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1706),
                            Descricao = "Envolve mundos imaginários, magia, criaturas místicas e heróis épicos. Ex: O Senhor dos Anéis.",
                            Genero = 1,
                            Nome = "Fantasia"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1711),
                            Descricao = "Explora futuros possíveis, tecnologia avançada, vida em outros planetas, inteligência artificial, etc.",
                            Genero = 1,
                            Nome = "Ficção Científica"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1747),
                            Descricao = "Visa provocar medo ou tensão. Pode incluir elementos sobrenaturais, psicológicos ou monstros.",
                            Genero = 1,
                            Nome = "Terror/Horror"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1749),
                            Descricao = "Narrativas cheias de tensão e mistério, com reviravoltas e sensação de perigo constante.",
                            Genero = 1,
                            Nome = "Suspense/Thriller"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1750),
                            Descricao = "Histórias com exploração, ação e desafios físicos ou geográficos. Muitas vezes envolvem viagens e descobertas.",
                            Genero = 1,
                            Nome = "Aventura"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1751),
                            Descricao = "Gira em torno de investigações, assassinatos ou crimes, com detetives, policiais ou investigadores.",
                            Genero = 1,
                            Nome = "Policial/Crime"
                        },
                        new
                        {
                            Id = 8,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1753),
                            Descricao = "Mostra sociedades futuristas \"perfeitas\" (utopias) ou opressoras e disfuncionais (distopias). Ex: 1984, Admirável Mundo Novo.",
                            Genero = 1,
                            Nome = "Distopia/Utopia"
                        },
                        new
                        {
                            Id = 9,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1754),
                            Descricao = "Foca em dilemas humanos, conflitos emocionais e desenvolvimento pessoal.",
                            Genero = 1,
                            Nome = "Drama"
                        },
                        new
                        {
                            Id = 10,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1755),
                            Descricao = "Escrita para crianças e adolescentes, muitas vezes com lições morais e linguagem acessível.",
                            Genero = 1,
                            Nome = "Literatura Infantojuvenil"
                        },
                        new
                        {
                            Id = 11,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1756),
                            Descricao = "Histórias da vida real de pessoas (biografias escritas por terceiros ou autobiografias escritas pelo próprio autor).",
                            Genero = 2,
                            Nome = "Biografia/Autobiografia"
                        },
                        new
                        {
                            Id = 12,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1757),
                            Descricao = "Oferece conselhos e reflexões para melhorar aspectos da vida pessoal, emocional ou profissional.",
                            Genero = 2,
                            Nome = "Autoajuda/Desenvolvimento Pessoal"
                        },
                        new
                        {
                            Id = 13,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1759),
                            Descricao = "Relatos e análises sobre eventos históricos, períodos ou civilizações.",
                            Genero = 2,
                            Nome = "História"
                        },
                        new
                        {
                            Id = 14,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1760),
                            Descricao = "Explicações e explorações sobre o mundo natural, física, biologia, astronomia, etc.",
                            Genero = 2,
                            Nome = "Ciência"
                        },
                        new
                        {
                            Id = 15,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1762),
                            Descricao = "Discute questões existenciais, éticas, morais e o pensamento humano ao longo da história.",
                            Genero = 2,
                            Nome = "Filosofia"
                        },
                        new
                        {
                            Id = 16,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1764),
                            Descricao = "Explora crenças, tradições religiosas, textos sagrados e espiritualidade em geral.",
                            Genero = 2,
                            Nome = "Religião/Espiritualidade"
                        },
                        new
                        {
                            Id = 17,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1765),
                            Descricao = "Foca em empreendedorismo, mercado financeiro, administração e carreiras.",
                            Genero = 2,
                            Nome = "Negócios/Economia"
                        },
                        new
                        {
                            Id = 18,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1766),
                            Descricao = "Livros para aprendizado de matérias escolares, técnicas ou idioma",
                            Genero = 2,
                            Nome = "Educação/Didáticos"
                        },
                        new
                        {
                            Id = 19,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1767),
                            Descricao = "Receitas, técnicas de cozinha e cultura alimentar.",
                            Genero = 2,
                            Nome = "Culinária/Gastronomia"
                        },
                        new
                        {
                            Id = 20,
                            Ativo = true,
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1768),
                            Descricao = "Relatos de experiências em outros países, guias turísticos e dicas de roteiros.",
                            Genero = 2,
                            Nome = "Viagens"
                        });
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExemplarId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExemplarId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimo", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Exemplar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CodigoBarras")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstadoConservacao")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.ToTable("Exemplar", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionario", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cargo = "Administrador",
                            CriadoEm = new DateTime(2025, 6, 18, 7, 54, 27, 319, DateTimeKind.Local).AddTicks(1939),
                            DataAdmissao = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@exemplo.com",
                            Matricula = "12345",
                            Nome = "Admin",
                            Senha = "****"
                        });
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoPublicacao")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Livro", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.LivroAutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("LivroId");

                    b.ToTable("LivroAutor", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.LivroCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("LivroId");

                    b.ToTable("LivroCategoria", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ExcluidoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Emprestimo", b =>
                {
                    b.HasOne("RegerBiblioteca.Core.Entities.Exemplar", "Exemplar")
                        .WithMany()
                        .HasForeignKey("ExemplarId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RegerBiblioteca.Core.Entities.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RegerBiblioteca.Core.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exemplar");

                    b.Navigation("Funcionario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Exemplar", b =>
                {
                    b.HasOne("RegerBiblioteca.Core.Entities.Livro", "Livro")
                        .WithMany("Exemplares")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.LivroAutor", b =>
                {
                    b.HasOne("RegerBiblioteca.Core.Entities.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegerBiblioteca.Core.Entities.Livro", "Livro")
                        .WithMany("Autores")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.LivroCategoria", b =>
                {
                    b.HasOne("RegerBiblioteca.Core.Entities.Categoria", "Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegerBiblioteca.Core.Entities.Livro", "Livro")
                        .WithMany("Categorias")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Categoria", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("RegerBiblioteca.Core.Entities.Livro", b =>
                {
                    b.Navigation("Autores");

                    b.Navigation("Categorias");

                    b.Navigation("Exemplares");
                });
#pragma warning restore 612, 618
        }
    }
}
