
namespace Event_System.Domain.Core.Events;

/// <summary>
/// Represents a domain event in the system.
/// </summary>
public abstract record DomainEvent : IDomainEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainEvent"/> class with a unique identifier and the current UTC time.
    /// </summary>
    public DomainEvent() : this(Guid.NewGuid(), DateTime.UtcNow)
    {

    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DomainEvent"/> class with the specified identifier and occurrence time.
    /// </summary>
    /// <param name="id">The unique identifier for the domain event.</param>
    /// <param name="occurredOn">The date and time when the event occurred.</param>
    private DomainEvent(Guid id, DateTime occuerredOn)
    {
        Id = id;
        OccuerredOn = occuerredOn;
    }

    /// <summary>
    /// Gets the unique identifier for the domain event.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Gets the date and time when the event occurred.
    /// </summary>
    public DateTime OccuerredOn { get; }
}
