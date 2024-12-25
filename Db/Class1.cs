using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class ShopDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Bank;Integrated Security=SSPI;");
        }

        public DbSet< MyProperty { get; set; }
    }
}
