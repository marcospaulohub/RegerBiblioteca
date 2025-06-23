using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly DBContext _context;

        public EmprestimoRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Emprestimo item)
        {
            _context.Emprestimos.Add(item);
            _context.SaveChanges();
            
            return item.Id;
        }

        public void Update(Emprestimo item)
        {
            item.DefinirComoAtualizado();

            _context.Emprestimos.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Emprestimo item)
        {
            item.DefinirComoExcluido();

            _context.Emprestimos.Update(item);
            _context.SaveChanges();
        }
        public Emprestimo GetById(int id)
        {
            var emprestimo = _context
                .Emprestimos
                .SingleOrDefault(e => e.Id == id && e.ExcluidoEm == null);

            return emprestimo;
        }

        public IEnumerable<Emprestimo> GetAll()
        {
            var listaEmprestimos = _context
                .Emprestimos
                .Where(e => e.ExcluidoEm == null)
                .ToList();

            return listaEmprestimos;
        }
    }
}
