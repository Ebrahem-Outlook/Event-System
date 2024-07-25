
namespace Event_System.Domain.Core.BaseType;

/// <summary>
/// Defines a contract for soft deletable entityies.
/// </summary>
public interface ISoftDeletable
{
    bool IsDeleted { get; }
    DateTime? DeletedAt { get; }
    void SoftDelete();
    void Restore();
}
