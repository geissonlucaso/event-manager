using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EventManager.Models
{
    public class EventManagerContextFactory : IDesignTimeDbContextFactory<EventManagerContext>
    {
        public EventManagerContext CreateDbContext(string[] args)
        {
            // Configurar a leitura do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<EventManagerContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            return new EventManagerContext(optionsBuilder.Options);
        }
    }
}
