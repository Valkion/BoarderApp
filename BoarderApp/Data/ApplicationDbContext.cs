using BoarderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BoarderApp.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)

        {

        }
        public DbSet<Customer> Customers { get; set; }      
        public DbSet<Unit> Units { get; set; }
    }
}
