using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Infra.Persistence.Mappings;

namespace RegerBiblioteca.Infra.Persistence
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options) { }

        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
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

            base.OnModelCreating(builder);
        }
    }
}
