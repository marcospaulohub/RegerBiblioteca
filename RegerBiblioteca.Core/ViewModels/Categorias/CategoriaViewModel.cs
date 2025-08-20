using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.ViewModels.Categorias
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel(int id, string nome, string? descricao, Genero genero, bool ativo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Genero = ObterDescricaoGenero(genero);
            Ativo = ativo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string Genero { get; set; }
        public bool Ativo { get; set; }


        public static CategoriaViewModel FromEntity(Categoria categoria)
            => new(
                categoria.Id,
                categoria.Nome,
                categoria.Descricao,
                categoria.Genero,
                categoria.Ativo);

        private static string ObterDescricaoGenero(Genero genero) 
            => genero switch
        {
            Core.Enums.Genero.Ficcao => "Ficção",
            Core.Enums.Genero.NaoFiccao => "Não Ficção",
            _ => "Desconhecido"
        };
    }
}
