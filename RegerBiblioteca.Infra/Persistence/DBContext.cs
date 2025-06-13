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

            base.OnModelCreating(builder);
        }
    }
}
