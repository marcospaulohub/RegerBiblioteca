using RegerBiblioteca.App.Models.Categorias;
using RegerBiblioteca.App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegerBiblioteca.App.Services
{
    public class CategoriaService : ICategoriaService
    {
        public ResultViewModel<int> Create(CreateCategoriaInputModel model)
        {
            throw new NotImplementedException();
        }
        public ResultViewModel Update(int id, UpdateCategoriaInputModel model)
        {
            throw new NotImplementedException();
        }
        public ResultViewModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel<CategoriaViewModel?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ResultViewModel<List<CategoriaViewModel?>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
