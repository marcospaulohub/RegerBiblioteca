using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly DBContext _context;

        public AutorRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Autor item)
        {
            _context.Autores.Add(item);
            _context.SaveChanges();
            
            return item.Id;
        }

        public void Update(Autor item)
        {
            item.DefinirComoAtualizado();

            _context.Autores.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Autor item)
        {
            item.DefinirComoExcluido();

            _context.Autores.Update(item);
            _context.SaveChanges();
        }
        public Autor? GetById(int id)
        {
            var autor = _context
                .Autores
                .Include(a => a.Livros)
                    .ThenInclude(la => la.Livro)
                .SingleOrDefault(a => a.Id == id && a.ExcluidoEm == null);

            return autor;
        }

        public IEnumerable<Autor> GetAll()
        {
            var listaLivros = _context
                .Autores
                .Include(a => a.Livros)
                    .ThenInclude(la => la.Livro)
                .Where(a => a.ExcluidoEm == null)
                .ToList();

            return listaLivros;
        }
    }
}
