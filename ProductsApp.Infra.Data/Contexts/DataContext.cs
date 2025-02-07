using Microsoft.EntityFrameworkCore;
using ProductsApp.Infrastructure.Mappings;

namespace ProductsApp.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor para injeção de dependência
        /// </summary>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /// <summary>
        /// Método para adicionarmos as classes de mapeamento do projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}


