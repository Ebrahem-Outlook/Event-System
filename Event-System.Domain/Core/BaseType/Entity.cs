
using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Core.BaseType;

/// <summary>
/// Represents a base class for all entities in the domain.
/// </summary>
public abstract class Entity : IEquatable<Entity?>, IEntity
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    protected Entity(Guid id) => Id = id;

    /// <summary>
    /// 
    /// </summary>
    protected Entity() { }

    /// <summary>
    /// 
    /// </summary>
    public Guid Id { get; }
  
    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return Equals(obj as Entity);
    }

    /// <inheritdoc/>
    public bool Equals(Entity? other)
    {
        return other is not null &&
               Id.Equals(other.Id);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    /// <summary>
    /// Determines whether two specified instances of <see cref="Entity"/> are equal.
    /// </summary>
    /// <param name="left">The first entity to compare.</param>
    /// <param name="right">The second entity to compare.</param>
    /// <returns><c>true</c> if the specified entities are equal; otherwise, <c>false</c>.</returns>
    public static bool operator ==(Entity? left, Entity? right)
    {
        return EqualityComparer<Entity>.Default.Equals(left, right);
    }

    /// <summary>
    /// Determines whether two specified instances of <see cref="Entity"/> are not equal.
    /// </summary>
    /// <param name="left">The first entity to compare.</param>
    /// <param name="right">The second entity to compare.</param>
    /// <returns><c>true</c> if the specified entities are not equal; otherwise, <c>false</c>.</returns>
    public static bool operator !=(Entity? left, Entity? right)
    {
        return !(left == right);
    }
}
