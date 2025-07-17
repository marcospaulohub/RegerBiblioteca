using Microsoft.EntityFrameworkCore;
using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DBContext _context;
        public LivroRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Livro item)
        {
            _context.Livros.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void Update(Livro item)
        {
            item.DefinirComoAtualizado();

            _context.Livros.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Livro item)
        {
            item.DefinirComoExcluido();

            _context.Livros.Update(item);
            _context.SaveChanges();
        }

        public Livro GetById(int id)
        {
            var livro = _context
                .Livros
                .Include(l => l.Autores)
                    .ThenInclude(la => la.Autor)
                .SingleOrDefault(l => l.Id == id && l.ExcluidoEm == null);
            
            return livro;
        }

        public IEnumerable<Livro> GetAll()
        {
            var listaLivros = _context
                .Livros
                .Include(l => l.Autores)
                    .ThenInclude(la => la.Autor)
                .Where(l => l.ExcluidoEm == null)
                .ToList();

            return listaLivros;
        }
    }
}
