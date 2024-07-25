
using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Core.BaseType;

/// <summary>
/// Represents a base class for all entities in the domain.
/// </summary>
public abstract class Entity : IEquatable<Entity?>, IEntity, IAuditable, ISoftDeletable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class with the specified identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the entity.</param>
    protected Entity(Guid id) => Id = id;

    // Parameterless constructor for EF Core
    protected Entity() { }

    /// <summary>
    /// Gets the unique identifier for the entity.
    /// </summary>
    public Guid Id { get; }

    public DateTime CreatedAt { get; }

    public DateTime? LastModifiedAt { get; private set; } 


    public bool IsDeleted => throw new NotImplementedException();

    public DateTime? DeletedAt => throw new NotImplementedException();

  
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

    public void SoftDelete()
    {
        throw new NotImplementedException();
    }

    public void Restore()
    {
        throw new NotImplementedException();
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
