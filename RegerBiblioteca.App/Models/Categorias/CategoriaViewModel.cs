using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.App.Models.Categorias
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel(string nome, string? descricao, Genero genero, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            Genero = genero;
            Ativo = ativo;
        }

        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public Genero Genero { get; set; }
        public bool Ativo { get; set; }


        public static CategoriaViewModel FromEntity(Categoria categoria)
            => new(
                categoria.Nome,
                categoria.Descricao,
                categoria.Genero,
                categoria.Ativo);
    }
}
