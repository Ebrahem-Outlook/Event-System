using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Customers.Events;

/// <summary>
/// 
/// </summary>
/// <param name="CustomerId"></param>
/// <param name="Email"></param>
public sealed record CustomerEmailUpdatedDomainEvent(
    Guid CustomerId, 
    string Email) : DomainEvent();
