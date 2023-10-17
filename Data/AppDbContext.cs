using azure_learning_biginner.Model;
using Microsoft.EntityFrameworkCore;

namespace azure_learning_biginner
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

    }
}
