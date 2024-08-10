using Microsoft.EntityFrameworkCore;

namespace AFPAS.Models
{
    public class AFPASDbContext : DbContext
    {
        public AFPASDbContext(DbContextOptions options) : base(options) { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<UNITS> units { get; set; }

        public DbSet<PERSONNEL> personnel { get; set; }
    }

}
