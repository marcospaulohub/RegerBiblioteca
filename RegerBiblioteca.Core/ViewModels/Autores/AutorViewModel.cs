using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Core.ViewModels.Autores
{
    public class AutorViewModel
    {
        public AutorViewModel(int id, string nome, string? nacionalidade, DateTime? dataNascimento, DateTime? dataFalecimento, string? biografia, string? fotoUrl, string? siteUrl)
        {
            Id = id;
            Nome = nome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
            DataFalecimento = dataFalecimento;
            Biografia = biografia;
            FotoUrl = fotoUrl;
            SiteUrl = siteUrl;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataFalecimento { get; set; }
        public string? Biografia { get; set; }
        public string? FotoUrl { get; set; }
        public string? SiteUrl { get; set; }

        public static AutorViewModel FromEntity(Autor autor)
            => new(
                autor.Id,
                autor.Nome,
                autor.Nacionalidade,
                autor.DataNascimento,
                autor.DataFalecimento,
                autor.Biografia,
                autor.FotoUrl,
                autor.SiteUrl);
    }
}
