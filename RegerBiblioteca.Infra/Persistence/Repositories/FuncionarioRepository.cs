using RegerBiblioteca.Core.Entities;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.Infra.Persistence.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DBContext _context;

        public FuncionarioRepository(DBContext context)
        {
            _context = context;
        }

        public int Insert(Funcionario item)
        {
            _context.Funcionarios.Add(item);
            _context.SaveChanges();

            return item.Id;
        }

        public void Update(Funcionario item)
        {
            item.DefinirComoAtualizado();

            _context.Funcionarios.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Funcionario item)
        {
            item.DefinirComoExcluido();

            _context.Funcionarios.Update(item);
            _context.SaveChanges();
        }
        public Funcionario GetById(int id)
        {
            var funcionario = _context
                .Funcionarios
                .SingleOrDefault(f => f.Id == id && f.ExcluidoEm == null);

            return funcionario;
        }

        public IEnumerable<Funcionario> GetAll()
        {
            var listaFuncionarios = _context
                .Funcionarios
                .Where(f => f.ExcluidoEm == null)
                .ToList();

            return listaFuncionarios;
        }
    }
}
