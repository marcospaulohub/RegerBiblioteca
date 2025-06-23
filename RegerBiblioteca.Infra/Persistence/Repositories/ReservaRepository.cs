using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly DBContext _context;
        public ReservaRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Reserva item)
        {
            _context.Reservas.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void Update(Reserva item)
        {
            item.DefinirComoAtualizado();

            _context.Reservas.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Reserva item)
        {
            item.DefinirComoExcluido();

            _context.Reservas.Update(item);
            _context.SaveChanges();
        }
        public Reserva GetById(int id)
        {
            var reserva = _context
                .Reservas
                .SingleOrDefault(r => r.Id == id && r.ExcluidoEm == null);
            
            return reserva;
        }

        public IEnumerable<Reserva> GetAll()
        {
            var listaReservas = _context
                .Reservas
                .Where(r => r.ExcluidoEm == null)
                .ToList();

            return listaReservas;
        }
    }
}
