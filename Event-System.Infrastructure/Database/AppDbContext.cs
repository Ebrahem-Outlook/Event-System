using Microsoft.EntityFrameworkCore;

namespace Event_System.Infrastructure;

public sealed class AppDbContext : DbContext, 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        Database.EnsureCreatedAsync();
    }

    
}
