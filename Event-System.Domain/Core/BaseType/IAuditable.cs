
namespace Event_System.Domain.Core.BaseType;

/// <summary>
/// Defines a contract for auditable entities.
/// </summary>
public interface IAuditable
{
    DateTime CreatedAt { get; }

    DateTime? LastModifiedAt { get; }
}
