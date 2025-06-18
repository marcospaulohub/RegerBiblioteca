using Microsoft.EntityFrameworkCore;

namespace RegerBiblioteca.Infra.Persistence.Mappings
{
    public static class ModelBuilderMappingExtensions
    {
        public static void Map(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AutorMap());
            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new EmprestimoMap());
            builder.ApplyConfiguration(new ExemplarMap());
            builder.ApplyConfiguration(new FuncionarioMap());
            builder.ApplyConfiguration(new LivroAutorMap());
            builder.ApplyConfiguration(new LivroCategoriaMap());
            builder.ApplyConfiguration(new LivroMap());
            builder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
