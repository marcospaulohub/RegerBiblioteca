using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Categoria : BaseEntity
    {
        public Categoria() { }

        public Categoria(string nome, string? descricao, Genero genero, bool ativo) : base()
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

        public List<LivroCategoria> Livros { get; set; } = [];
    }
}
