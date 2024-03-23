using AzureWebApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzureWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
