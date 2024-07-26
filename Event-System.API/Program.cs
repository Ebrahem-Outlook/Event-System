using Event_System.Infrastructure;
using Event_System.Persistence;

namespace Event_System.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add Service to the contaner.
        builder.Services.AddControllers();
        builder.Services.AddApplciation();
        builder.Services.AddInfrastructure();
        builder.Services.AddPersistence(builder.Configuration);
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }
}
