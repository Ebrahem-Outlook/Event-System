using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Event_System.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        string? connection = configuration.GetConnectionString("Docker-Postgres");

        services.AddDbContext<>


        return services;
    }
}
