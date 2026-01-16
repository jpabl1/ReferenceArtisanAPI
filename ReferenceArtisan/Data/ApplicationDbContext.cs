using Microsoft.EntityFrameworkCore;
using ReferenceArtisan.Entity;

namespace ReferenceArtisan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected ApplicationDbContext()
        {
        }
        public DbSet<Projects> Projects { get; set; }

    }
}
