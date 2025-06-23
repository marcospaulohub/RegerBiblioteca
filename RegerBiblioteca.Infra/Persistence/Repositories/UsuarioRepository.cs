using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DBContext _context;
        public UsuarioRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Usuario item)
        {
            _context.Usuarios.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void Update(Usuario item)
        {
            item.DefinirComoAtualizado();

            _context.Usuarios.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Usuario item)
        {
            item.DefinirComoExcluido();

            _context.Usuarios.Update(item);
            _context.SaveChanges();
        }
        
        public Usuario GetById(int id)
        {
            var usuario = _context
                .Usuarios
                .SingleOrDefault(u => u.Id == id && u.ExcluidoEm == null);

            return usuario;
        }

        public IEnumerable<Usuario> GetAll()
        {
            var listaUsuarios = _context
                .Usuarios
                .Where(u => u.ExcluidoEm == null)
                .ToList();

            return listaUsuarios;
        }
    }
}
