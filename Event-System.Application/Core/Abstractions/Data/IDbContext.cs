using Event_System.Domain.Core.BaseType;

namespace Event_System.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
