using Event_System.Application.Core.Abstractions.Data;
using Event_System.Domain.Customers;
using Event_System.Persistence.Caching;
using Event_System.Persistence.Database;
using Event_System.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Event_System.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            string? connection = configuration.GetConnectionString("Docker-Postgres");

            options.UseNpgsql(connection);
        });

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<ApplicationDbContext>());

        services.AddDistributedMemoryCache();
        services.AddMemoryCache();

        services.AddScoped<CustomerRepository>();

        services.AddScoped<ICustomerRepository>(serviceProvider =>
        {
            var decorated = serviceProvider.GetRequiredService<CustomerRepository>();

            var memoryCache = serviceProvider.GetRequiredService<IMemoryCache>();

            return new CachedCustomerRepository(decorated, memoryCache);
        });


        services.AddScoped<CustomerRepository>();

        services.AddScoped<ICustomerRepository>(serviceProvider =>
        {
            var decorated = serviceProvider.GetRequiredService<CustomerRepository>();

            var memoryCache = serviceProvider.GetRequiredService<IMemoryCache>();

            return new CachedCustomerRepository(decorated, memoryCache);
        });


        return services;
    }
}
