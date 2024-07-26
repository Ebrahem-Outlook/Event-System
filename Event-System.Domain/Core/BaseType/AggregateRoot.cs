using Event_System.Domain.Core.Events;
using System.Collections.Immutable;

namespace Event_System.Domain.Core.BaseType;

/// <summary>
/// Represents a base class for aggregate roots in the domain.
/// </summary>
public abstract class AggregateRoot : Entity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AggregateRoot"/> class with the specified identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the aggregate root.</param>
    protected AggregateRoot(Guid id) : base(id) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AggregateRoot"/> class.
    /// </summary>
    protected AggregateRoot() : base() { }

    private List<IDomainEvent> domainEvents = [];

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

    public void RaiseDomainEvent(IDomainEvent @event) => domainEvents.Add(@event);

    public void ClearDomainEvent() => domainEvents.Clear();
}
