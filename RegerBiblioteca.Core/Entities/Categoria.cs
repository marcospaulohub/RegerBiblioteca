using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.Core.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public Genero Genero { get; set; }
        public bool Ativo { get; set; }

        public List<LivroCategoria> Livros { get; set; } = [];
    }
}
