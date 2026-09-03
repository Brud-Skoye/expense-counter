using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Models
{
    public class MyWebAppDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public MyWebAppDbContext(DbContextOptions<MyWebAppDbContext> options)
                :base(options)
        {
                            
        }
    }
}
