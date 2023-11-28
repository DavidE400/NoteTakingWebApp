using DavidWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace DavidWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
    }
}
