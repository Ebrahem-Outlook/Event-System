using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Customers.Events;

/// <summary>
/// 
/// </summary>
/// <param name="CustomerId"></param>
public sealed record CustomerPasswordUpdatedDomainEvent(Guid CustomerId) : DomainEvent();
