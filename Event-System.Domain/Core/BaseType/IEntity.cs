
namespace Event_System.Domain.Core.BaseType;

/// <summary>
/// Defines a contract for entities.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Gets the unique identifier for the entity.
    /// </summary>
    Guid Id { get; }
}
