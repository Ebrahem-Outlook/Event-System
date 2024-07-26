using Event_System.Domain.Core.Events;

namespace Event_System.Domain.Customers.Events;

/// <summary>
/// 
/// </summary>
/// <param name="CustomerId"></param>
/// <param name="FirstName"></param>
/// <param name="LastName"></param>
public sealed record CustomerUpdatedDomainEvent(
    Guid CustomerId, 
    string FirstName, 
    string LastName) : DomainEvent();