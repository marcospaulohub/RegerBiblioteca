using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DBContext _context;

        public CategoriaRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Categoria item)
        {
            _context.Categorias.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void Update(Categoria item)
        {
            item.DefinirComoAtualizado();

            _context.Categorias.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Categoria item)
        {
            item.DefinirComoExcluido();

            _context.Categorias.Update(item);
            _context.SaveChanges();
        }
        public Categoria GetById(int id)
        {
            var categoria = _context
                .Categorias
                .SingleOrDefault(c => c.Id == id && c.ExcluidoEm == null);

            return categoria;
        }

        public IEnumerable<Categoria> GetAll()
        {
            var listaCategorias = _context
                .Categorias
                .Where(c => c.ExcluidoEm == null)
                .ToList();

            return listaCategorias;
        }
    }
}
