using Microsoft.EntityFrameworkCore;
using MyFinalProject.Models;

namespace MyFinalProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
        public DbSet<Game> Games { get; set; }
    }
}
