using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using ProjectFelixR.Models;

namespace ProjectFelixR
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ProjectDbContext>
    { 
        public ProjectDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectDbContext>();

            // Get the connection string from appsettings.json
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new ProjectDbContext(optionsBuilder.Options);
        }
    }
}
