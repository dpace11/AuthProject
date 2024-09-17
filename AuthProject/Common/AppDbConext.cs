using AuthProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Common
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
