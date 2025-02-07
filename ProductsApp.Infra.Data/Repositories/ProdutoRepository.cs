
using ProductsApp.Domain.Interfaces.Repositories;
using ProductsApp.Domain.Models;
using ProductsApp.Infra.Data.Contexts;

namespace ProductsApp.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto, Guid>, IProdutoRepository
    {
        public ProdutoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
