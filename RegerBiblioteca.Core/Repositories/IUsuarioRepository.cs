using RegerBiblioteca.Core.Entities;

namespace RegerBiblioteca.Core.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        public Usuario GetByEmail(string email);
    }
}
