using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Infra.Persistence.Mappings;

namespace RegerBiblioteca.Infra.Persistence
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Map(); // Aplicar os mapeamentos das entidades.
        }
    }
}
