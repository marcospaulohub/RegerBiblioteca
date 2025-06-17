namespace RegerBiblioteca.Core.Entities
{
    public class Autor : BaseEntity
    {
        public Autor() { }

        public Autor(string nome, 
                     string? nacionalidade, 
                     DateTime? dataNascimento, 
                     DateTime? dataFalecimento, 
                     string? biografia, 
                     string? fotoUrl, 
                     string? siteUrl) : base()
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            DataNascimento = dataNascimento;
            DataFalecimento = dataFalecimento;
            Biografia = biografia;
            FotoUrl = fotoUrl;
            SiteUrl = siteUrl;
        }

        public string Nome { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataFalecimento { get; set; }
        public string? Biografia { get; set; }
        public string? FotoUrl { get; set; }
        public string? SiteUrl { get; set; }

        public List<LivroAutor> Livros { get; set; } = [];
    }
}
