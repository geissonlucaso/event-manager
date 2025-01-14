using Microsoft.EntityFrameworkCore;

namespace EventManager.Models
{
    public class EventManagerContext : DbContext
    {
        public EventManagerContext(DbContextOptions<EventManagerContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

    }
}
