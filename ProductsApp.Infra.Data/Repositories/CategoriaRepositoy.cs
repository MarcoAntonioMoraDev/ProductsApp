using ProductsApp.Domain.Interfaces.Repositories;
using ProductsApp.Domain.Models;
using ProductsApp.Infra.Data.Contexts;

namespace ProductsApp.Infra.Data.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria, Guid>, ICategoriaRepository
    {
        public CategoriaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}



