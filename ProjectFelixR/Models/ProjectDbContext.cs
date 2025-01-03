using Microsoft.EntityFrameworkCore;

namespace ProjectFelixR.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Template> Templates { get; set; }
    }
}
