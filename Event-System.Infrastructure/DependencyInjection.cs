using Event_System.Application.Core.Abstractions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Event_System.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        string? connection = configuration.GetConnectionString("Docker-Postgres");

        services.AddDbContext<EventSystemDbContext>(options => options.UseNpgsql(connection));

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<EventSystemDbContext>());

        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<EventSystemDbContext>());

        return services;
    }
}
