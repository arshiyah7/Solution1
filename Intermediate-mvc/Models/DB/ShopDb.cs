using Intermediate_mvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Intermediate_mvc.Models.DB
{
    public class ShopDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Store;Integrated Security=SSPI;");
        }
        public DbSet<Product> Produc { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
