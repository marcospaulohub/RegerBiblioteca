using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class ExemplarRepository : IExemplarRepository
    {
        private readonly DBContext _context;

        public ExemplarRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Exemplar item)
        {
            _context.Exemplares.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void Update(Exemplar item)
        {
            item.DefinirComoAtualizado();

            _context.Exemplares.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Exemplar item)
        {
            item.DefinirComoExcluido();

            _context.Exemplares.Update(item);
            _context.SaveChanges();
        }
        
        public Exemplar GetById(int id)
        {
            var exemplar = _context
                .Exemplares
                .SingleOrDefault(e => e.Id == id && e.ExcluidoEm == null);

            return exemplar;
        }

        public IEnumerable<Exemplar> GetAll()
        {
            var listaExemplares = _context
                .Exemplares
                .Where(e => e.ExcluidoEm == null)
                .ToList();

            return listaExemplares;
        }

    }
}
